﻿# QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
# Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

from clr import AddReference
AddReference("System")
AddReference("QuantConnect.Algorithm")
AddReference("QuantConnect.Common")

from System import *
from QuantConnect import *
from QuantConnect.Data import *
from QuantConnect.Algorithm import *
from QuantConnect.Securities import *
from datetime import timedelta

### <summary>
### This example demonstrates how to get access to futures history for a given root symbol.
### It also shows how you can prefilter contracts easily based on expirations, and inspect the futures
### chain to pick a specific contract to trade.
### </summary>
### <meta name="tag" content="using data" />
### <meta name="tag" content="history and warm up" />
### <meta name="tag" content="history" />
### <meta name="tag" content="futures" />
class BasicTemplateFuturesHistoryAlgorithm(QCAlgorithm):

    def Initialize(self):
        self.SetStartDate(2013, 10, 8)
        self.SetEndDate(2013, 10, 9)
        self.SetCash(1000000)

        # Subscribe and set our expiry filter for the futures chain
        # find the front contract expiring no earlier than in 90 days
        futureES = self.AddFuture(Futures.Indices.SP500EMini, Resolution.Minute)
        futureES.SetFilter(timedelta(0), timedelta(182))

        futureGC = self.AddFuture(Futures.Metals.Gold, Resolution.Minute)
        futureGC.SetFilter(timedelta(0), timedelta(182))

        self.SetBenchmark(lambda x: 1000000)

        self.Schedule.On(self.DateRules.EveryDay(), self.TimeRules.Every(timedelta(hours=1)), self.MakeHistoryCall)
        self.successCount = 0

    def MakeHistoryCall(self):
        history = self.History(self.Securities.keys(), 10, Resolution.Minute)
        if len(history) < 10:
            raise Exception(f'Empty history at {self.Time}')
        self.successCount += 1

    def OnEndOfAlgorithm(self):
        if self.successCount < 49:
            raise Exception(f'Scheduled Event did not assert history call as many times as expected: {_successCount}/49')

    def OnData(self,slice):
        if self.Portfolio.Invested: return
        for chain in slice.FutureChains:
            for contract in chain.Value:
                self.Log(f'{contract.Symbol.Value},' +
                         f'Bid={contract.BidPrice} ' +
                         f'Ask={contract.AskPrice} ' +
                         f'Last={contract.LastPrice} ' +
                         f'OI={contract.OpenInterest}')

    def OnSecuritiesChanged(self, changes):
        for change in changes.AddedSecurities:
            history = self.History(change.Symbol, 10, Resolution.Minute).sort_index(level='time', ascending=False)[:3]

            for index, row in history.iterrows():
                self.Log(f'History: {index[1]} : {index[2]:%m/%d/%Y %I:%M:%S %p} > {row.close}')

    def OnOrderEvent(self, orderEvent):
        # Order fill event handler. On an order fill update the resulting information is passed to this method.
        # Order event details containing details of the events
        self.Log(f'{orderEvent}')