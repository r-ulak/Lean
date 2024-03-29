/*
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
using Python.Runtime;
using QuantConnect.Data.Fundamental;
using QuantConnect.Securities;

namespace QuantConnect.Data.UniverseSelection
{
    /// <summary>
    /// Provides a universe that can be filtered with a <see cref="FineFundamental"/> selection function
    /// </summary>
    public class FineFundamentalFilteredUniverse : SelectSymbolsUniverseDecorator
    {
        /// <summary>
        /// The universe that will be used for fine universe selection
        /// </summary>
        public FineFundamentalUniverse FineFundamentalUniverse { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineFundamentalFilteredUniverse"/> class
        /// </summary>
        /// <param name="universe">The universe to be filtered</param>
        /// <param name="fineSelector">The fine selection function</param>
        public FineFundamentalFilteredUniverse(Universe universe, Func<IEnumerable<FineFundamental>, IEnumerable<Symbol>> fineSelector)
            : base(universe, universe.SelectSymbols)
        {
            FineFundamentalUniverse = new FineFundamentalUniverse(universe.UniverseSettings, universe.SecurityInitializer, fineSelector);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineFundamentalFilteredUniverse"/> class
        /// </summary>
        /// <param name="universe">The universe to be filtered</param>
        /// <param name="fineSelector">The fine selection function</param>
        public FineFundamentalFilteredUniverse(Universe universe, PyObject fineSelector)
            : base(universe, universe.SelectSymbols)
        {
            var func = fineSelector.ConvertToDelegate<Func< IEnumerable<FineFundamental>, Symbol[]>>();
            FineFundamentalUniverse = new FineFundamentalUniverse(universe.UniverseSettings, universe.SecurityInitializer, func);
        }

        /// <summary>
        /// Sets the security initializer, used to initialize/configure securities after creation
        /// </summary>
        /// <param name="securityInitializer">The security initializer</param>
        public override void SetSecurityInitializer(ISecurityInitializer securityInitializer)
        {
            base.SetSecurityInitializer(securityInitializer);
            Universe.SetSecurityInitializer(securityInitializer);
            FineFundamentalUniverse.SetSecurityInitializer(securityInitializer);
        }
    }
}