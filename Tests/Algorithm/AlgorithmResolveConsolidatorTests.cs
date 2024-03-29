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

using System.Linq;
using NUnit.Framework;
using QuantConnect.Algorithm;
using QuantConnect.Data.Market;
using QuantConnect.Tests.Engine.DataFeeds;
using QuantConnect.Util;

namespace QuantConnect.Tests.Algorithm
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class AlgorithmResolveConsolidatorTests
    {
        [TestCase(SecurityType.Equity, TickType.Trade, "SPY")]
        [TestCase(SecurityType.Crypto, TickType.Trade, "BTCUSD")]
        [TestCase(SecurityType.Forex, TickType.Quote, "EURUSD")]
        [TestCase(SecurityType.Cfd, TickType.Quote, "WTICOUSD")]
        public void ConsolidatorHasSameTypeAsSubscriptionDataConfig(SecurityType securityType, TickType expectedTickType, string ticker)
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddSecurity(securityType, ticker);
            var consolidator = algorithm.ResolveConsolidator(ticker, Resolution.Minute);

            var inputType = security.Subscriptions.Single(s=>s.TickType==expectedTickType).Type;
            var outputType = consolidator.OutputType;

            Assert.AreEqual(inputType, outputType);
        }

        [Test]
        public void TradeBarToTradeBar()
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddEquity("SPY");
            var consolidator = algorithm.ResolveConsolidator("SPY", Resolution.Minute);

            var inputType = security.Subscriptions.Single(s => s.TickType == LeanData.GetCommonTickType(SecurityType.Equity)).Type;
            var outputType = consolidator.OutputType;

            Assert.AreEqual(inputType, outputType);
        }

        [Test]
        public void QuoteBarToQuoteBar()
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddForex("EURUSD");
            var consolidator = algorithm.ResolveConsolidator("EURUSD", Resolution.Minute);

            var inputType = security.SubscriptionDataConfig.Type;
            var outputType = consolidator.OutputType;

            Assert.AreEqual(inputType, outputType);
        }

        [Test]
        public void TickTypeTradeToTradeBar()
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddEquity("SPY", Resolution.Tick);
            var consolidator = algorithm.ResolveConsolidator("SPY", Resolution.Minute);

            var tickType = security.Subscriptions.Single(s => s.TickType == LeanData.GetCommonTickType(SecurityType.Equity)).TickType;
            var outputType = consolidator.OutputType;

            Assert.AreEqual(TickType.Trade, tickType);
            Assert.AreEqual(typeof(TradeBar), outputType);
        }

        [Test]
        public void TickTypeQuoteToQuoteBar()
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddForex("EURUSD", Resolution.Tick);
            var consolidator = algorithm.ResolveConsolidator("EURUSD", Resolution.Minute);

            var tickType = security.Subscriptions.Single(s => s.TickType == LeanData.GetCommonTickType(SecurityType.Forex)).TickType;

            var outputType = consolidator.OutputType;

            Assert.AreEqual(TickType.Quote, tickType);
            Assert.AreEqual(typeof(QuoteBar), outputType);
        }

        [Test]
        public void TickTypeTradeToTick()
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddEquity("SPY", Resolution.Tick);
            var consolidator = algorithm.ResolveConsolidator("SPY", Resolution.Tick);

            var tickType = security.Subscriptions.Single(s => s.TickType == LeanData.GetCommonTickType(SecurityType.Equity)).TickType;
            var inputType = security.SubscriptionDataConfig.Type;
            var outputType = consolidator.OutputType;

            Assert.AreEqual(TickType.Trade, tickType);
            Assert.AreEqual(inputType, outputType);
        }

        [Test]
        public void TickTypeQuoteToTick()
        {
            var algorithm = new QCAlgorithm();
            algorithm.SubscriptionManager.SetDataManager(new DataManagerStub(algorithm));
            var security = algorithm.AddForex("EURUSD", Resolution.Tick);
            var consolidator = algorithm.ResolveConsolidator("EURUSD", Resolution.Tick);

            var tickType = security.SubscriptionDataConfig.TickType;
            var inputType = security.SubscriptionDataConfig.Type;
            var outputType = consolidator.OutputType;

            Assert.AreEqual(TickType.Quote, tickType);
            Assert.AreEqual(inputType, outputType);
        }
    }
}
