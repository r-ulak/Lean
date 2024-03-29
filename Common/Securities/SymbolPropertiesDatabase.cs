﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace QuantConnect.Securities
{
    /// <summary>
    /// Provides access to specific properties for various symbols
    /// </summary>
    public class SymbolPropertiesDatabase
    {
        private static SymbolPropertiesDatabase _dataFolderSymbolPropertiesDatabase;
        private static readonly object DataFolderSymbolPropertiesDatabaseLock = new object();

        private readonly IReadOnlyDictionary<SecurityDatabaseKey, SymbolProperties> _entries;
        private readonly IReadOnlyDictionary<SecurityDatabaseKey, SecurityDatabaseKey> _keyBySecurityType;

        private SymbolPropertiesDatabase(string file)
        {
            var allEntries = new Dictionary<SecurityDatabaseKey, SymbolProperties>();
            var entriesBySecurityType = new Dictionary<SecurityDatabaseKey, SecurityDatabaseKey>();

            foreach (var keyValuePair in FromCsvFile(file))
            {
                if (allEntries.ContainsKey(keyValuePair.Key))
                {
                    throw new DuplicateNameException($"Encountered duplicate key while processing file: {file}. Key: {keyValuePair.Key}");
                }
                // we wildcard the market, so per security type and symbol we will keep the *first* instance
                // this allows us to fetch deterministically, in O(1), an entry without knowing the market, see 'TryGetMarket()'
                var key = new SecurityDatabaseKey(SecurityDatabaseKey.Wildcard, keyValuePair.Key.Symbol, keyValuePair.Key.SecurityType);
                if (!entriesBySecurityType.ContainsKey(key))
                {
                    entriesBySecurityType[key] = keyValuePair.Key;
                }
                allEntries[keyValuePair.Key] = keyValuePair.Value;
            }

            _entries = allEntries;
            _keyBySecurityType = entriesBySecurityType;
        }

        /// <summary>
        /// Check whether symbol properties exists for the specified market/symbol/security-type
        /// </summary>
        /// <param name="market">The market the exchange resides in, i.e, 'usa', 'fxcm', ect...</param>
        /// <param name="symbol">The particular symbol being traded</param>
        /// <param name="securityType">The security type of the symbol</param>
        public bool ContainsKey(string market, string symbol, SecurityType securityType)
        {
            var key = new SecurityDatabaseKey(market, symbol, securityType);
            return _entries.ContainsKey(key);
        }

        /// <summary>
        /// Check whether symbol properties exists for the specified market/symbol/security-type
        /// </summary>
        /// <param name="market">The market the exchange resides in, i.e, 'usa', 'fxcm', ect...</param>
        /// <param name="symbol">The particular symbol being traded (Symbol class)</param>
        /// <param name="securityType">The security type of the symbol</param>
        public bool ContainsKey(string market, Symbol symbol, SecurityType securityType)
        {
            return ContainsKey(
                market,
                MarketHoursDatabase.GetDatabaseSymbolKey(symbol),
                securityType);
        }

        /// <summary>
        /// Tries to get the market for the provided symbol/security type
        /// </summary>
        /// <param name="symbol">The particular symbol being traded</param>
        /// <param name="securityType">The security type of the symbol</param>
        /// <param name="market">The market the exchange resides in <see cref="Market"/></param>
        /// <returns>True if market was retrieved, false otherwise</returns>
        public bool TryGetMarket(string symbol, SecurityType securityType, out string market)
        {
            SecurityDatabaseKey result;
            var key = new SecurityDatabaseKey(SecurityDatabaseKey.Wildcard, symbol, securityType);
            if (_keyBySecurityType.TryGetValue(key, out result))
            {
                market = result.Market;
                return true;
            }

            market = null;
            return false;
        }

        /// <summary>
        /// Gets the symbol properties for the specified market/symbol/security-type
        /// </summary>
        /// <param name="market">The market the exchange resides in, i.e, 'usa', 'fxcm', ect...</param>
        /// <param name="symbol">The particular symbol being traded</param>
        /// <param name="securityType">The security type of the symbol</param>
        /// <param name="defaultQuoteCurrency">Specifies the quote currency to be used when returning a default instance of an entry is not found in the database</param>
        /// <returns>The symbol properties matching the specified market/symbol/security-type or null if not found</returns>
        public SymbolProperties GetSymbolProperties(string market, string symbol, SecurityType securityType, string defaultQuoteCurrency)
        {
            SymbolProperties symbolProperties;
            var key = new SecurityDatabaseKey(market, symbol, securityType);

            if (!_entries.TryGetValue(key, out symbolProperties))
            {
                // now check with null symbol key
                if (!_entries.TryGetValue(new SecurityDatabaseKey(market, null, securityType), out symbolProperties))
                {
                    // no properties found, return object with default property values
                    return SymbolProperties.GetDefault(defaultQuoteCurrency);
                }
            }

            return symbolProperties;
        }

        /// <summary>
        /// Gets the symbol properties for the specified market/symbol/security-type
        /// </summary>
        /// <param name="market">The market the exchange resides in, i.e, 'usa', 'fxcm', ect...</param>
        /// <param name="symbol">The particular symbol being traded (Symbol class)</param>
        /// <param name="securityType">The security type of the symbol</param>
        /// <param name="defaultQuoteCurrency">Specifies the quote currency to be used when returning a default instance of an entry is not found in the database</param>
        /// <returns>The symbol properties matching the specified market/symbol/security-type or null if not found</returns>
        public SymbolProperties GetSymbolProperties(string market, Symbol symbol, SecurityType securityType, string defaultQuoteCurrency)
        {
            return GetSymbolProperties(
                market,
                MarketHoursDatabase.GetDatabaseSymbolKey(symbol),
                securityType,
                defaultQuoteCurrency);
        }

        /// <summary>
        /// Gets a list of symbol properties for the specified market/security-type
        /// </summary>
        /// <param name="market">The market the exchange resides in, i.e, 'usa', 'fxcm', ect...</param>
        /// <param name="securityType">The security type of the symbol</param>
        /// <returns>An IEnumerable of symbol properties matching the specified market/security-type</returns>
        public IEnumerable<KeyValuePair<SecurityDatabaseKey, SymbolProperties>> GetSymbolPropertiesList(string market, SecurityType securityType)
        {
            foreach (var entry in _entries)
            {
                var key = entry.Key;
                var symbolProperties = entry.Value;

                if (key.Market == market && key.SecurityType == securityType)
                {
                    yield return new KeyValuePair<SecurityDatabaseKey, SymbolProperties>(key, symbolProperties);
                }
            }
        }

        /// <summary>
        /// Gets the instance of the <see cref="SymbolPropertiesDatabase"/> class produced by reading in the symbol properties
        /// data found in /Data/symbol-properties/
        /// </summary>
        /// <returns>A <see cref="SymbolPropertiesDatabase"/> class that represents the data in the symbol-properties folder</returns>
        public static SymbolPropertiesDatabase FromDataFolder()
        {
            lock (DataFolderSymbolPropertiesDatabaseLock)
            {
                if (_dataFolderSymbolPropertiesDatabase == null)
                {
                    var directory = Path.Combine(Globals.DataFolder, "symbol-properties");
                    _dataFolderSymbolPropertiesDatabase = new SymbolPropertiesDatabase(Path.Combine(directory, "symbol-properties-database.csv"));
                }
            }
            return _dataFolderSymbolPropertiesDatabase;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="SymbolPropertiesDatabase"/> class by reading the specified csv file
        /// </summary>
        /// <param name="file">The csv file to be read</param>
        /// <returns>A new instance of the <see cref="SymbolPropertiesDatabase"/> class representing the data in the specified file</returns>
        private static IEnumerable<KeyValuePair<SecurityDatabaseKey, SymbolProperties>> FromCsvFile(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("Unable to locate symbol properties file: " + file);
            }

            // skip the first header line, also skip #'s as these are comment lines
            foreach (var line in File.ReadLines(file).Where(x => !x.StartsWith("#") && !string.IsNullOrWhiteSpace(x)).Skip(1))
            {
                SecurityDatabaseKey key;
                var entry = FromCsvLine(line, out key);

                yield return new KeyValuePair<SecurityDatabaseKey, SymbolProperties>(key, entry);
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="SymbolProperties"/> from the specified csv line
        /// </summary>
        /// <param name="line">The csv line to be parsed</param>
        /// <param name="key">The key used to uniquely identify this security</param>
        /// <returns>A new <see cref="SymbolProperties"/> for the specified csv line</returns>
        private static SymbolProperties FromCsvLine(string line, out SecurityDatabaseKey key)
        {
            var csv = line.Split(',');

            key = new SecurityDatabaseKey(
                market: csv[0],
                symbol: csv[1],
                securityType: (SecurityType)Enum.Parse(typeof(SecurityType), csv[2], true));

            return new SymbolProperties(
                description: csv[3],
                quoteCurrency: csv[4],
                contractMultiplier: csv[5].ToDecimal(),
                minimumPriceVariation: csv[6].ToDecimalAllowExponent(),
                lotSize: csv[7].ToDecimal());
        }


    }
}
