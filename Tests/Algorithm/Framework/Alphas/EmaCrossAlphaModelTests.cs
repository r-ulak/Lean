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

using NUnit.Framework;
using Python.Runtime;
using QuantConnect.Algorithm.Framework.Alphas;
using System;
using System.Collections.Generic;

namespace QuantConnect.Tests.Algorithm.Framework.Alphas
{
    [TestFixture]
    public class EmaCrossAlphaModelTests : CommonAlphaModelTests
    {
        protected override IAlphaModel CreateCSharpAlphaModel() => new EmaCrossAlphaModel();

        protected override IAlphaModel CreatePythonAlphaModel()
        {
            using (Py.GIL())
            {
                dynamic model = Py.Import("EmaCrossAlphaModel").GetAttr("EmaCrossAlphaModel");
                var instance = model();
                return new AlphaModelPythonWrapper(instance);
            }
        }

        protected override IEnumerable<Insight> ExpectedInsights()
        {
            var period = TimeSpan.FromDays(12);

            return new[]
            {
                Insight.Price(Symbols.SPY, period, InsightDirection.Down),
                Insight.Price(Symbols.SPY, period, InsightDirection.Up)
            };
        }

        protected override string GetExpectedModelName(IAlphaModel model)
        {
            return $"{nameof(EmaCrossAlphaModel)}(12,26,Daily)";
        }
    }
}
