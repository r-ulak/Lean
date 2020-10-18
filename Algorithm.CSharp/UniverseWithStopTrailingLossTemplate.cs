using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Brokerages;
using QuantConnect.Data.Market;
using QuantConnect.Data.UniverseSelection;
using QuantConnect.Orders;

namespace QuantConnect.Algorithm.CSharp
{
    public class UniverseWithStopTrailingLossTemplate : QCAlgorithm
    {
        SecurityChanges securityChanges = SecurityChanges.None;
        List<StockData> highDollarVolumeStocks = new List<StockData>();
        int totalHighDollarVolumeStocks = 10;
        int totalSortedStocks = 1;
        private decimal stopLossPercent = 0.95m;
        Resolution resolution = Resolution.Daily;
        private Dictionary<string, OrderTicket> stopMarketTicket;
        private Dictionary<string, decimal> highestPrice;

        public override void Initialize()
        {
            UniverseSettings.Resolution = resolution;
            stopMarketTicket = new Dictionary<string, OrderTicket>();
            highestPrice = new Dictionary<string, decimal>();

            SetStartDate(2006, 1, 1);
            SetEndDate(DateTime.Now);
            SetCash(10000);
            SetBrokerageModel(BrokerageName.Alpaca, AccountType.Margin);
            AddUniverse(coarse =>
            {
                return (from stock in coarse
                            //where stock.HasFundamentalData
                        orderby stock.DollarVolume descending
                        select stock.Symbol).Take(totalHighDollarVolumeStocks);
            });
            Log($"Initialize");

        }

        public override void OnOrderEvent(OrderEvent orderEvent)
        {
            if (orderEvent.Status == OrderStatus.Filled && orderEvent.Direction == OrderDirection.Buy)
            {
                OrderTicket orderTicket;
                if (stopMarketTicket.TryGetValue(orderEvent.Symbol.Value, out orderTicket)
                    & orderTicket?.OrderId > 0)
                {
                    orderTicket.Update(new UpdateOrderFields()
                    {
                        StopPrice = stopLossPercent * highestPrice[orderEvent.Symbol.Value]
                    });
                }
                else
                {
                    stopMarketTicket[orderEvent.Symbol.Value]
                        = StopMarketOrder(orderEvent.Symbol,
                            -Portfolio[orderEvent.Symbol].Quantity,
                    highestPrice[orderEvent.Symbol.Value] * stopLossPercent);
                }
            }
        }
        public void OnData(TradeBars data)
        {

            int period = 3;
            Log($"highDollarVolumeStocks Stocks {string.Join(",", highDollarVolumeStocks.Select(x => x.Ticker))}");
            foreach (StockData stockData in highDollarVolumeStocks)
            {

                if (Securities.ContainsKey(stockData.Ticker))
                {
                    TradeBar[] bars = History(stockData.Ticker, period, resolution).ToArray();
                    decimal[] closes = bars.Select(x => x.Close).ToArray();
                    if (bars != null && bars.Length == period)
                    {
                        stockData.Changes1 = ChangesPercent(closes);
                        stockData.Changes2 = Changes(stockData.Changes1);
                        stockData.Fitness = -stockData.Changes1.Last();
                        if (stockData.Changes2.Last() < 0)
                        {
                            stockData.Fitness = -1000;
                        }
                    }
                }
                else
                {
                    stockData.Fitness = -1000;
                }
            }
            var sortedStocksEnumerable = from x in highDollarVolumeStocks
                                         orderby x.Fitness descending
                                         select x;

            List<StockData> sortedStocks = sortedStocksEnumerable.Where(x => x.Fitness > 0m).Take(totalSortedStocks).ToList();
            Log($"Sorted Stocks {sortedStocks.Count}");
            foreach (var security in Portfolio.Values)
            {
                if (Securities.ContainsKey(security.Symbol))
                {
                    if (sortedStocks.Exists(x => x.Ticker == security.Symbol) == false)
                    {
                        Liquidate(security.Symbol);
                    }
                }
            }
            foreach (var security in sortedStocks)
            {
                Log($"security.Ticker {security.Ticker}");
                if (Securities.ContainsKey(security.Ticker))
                {
                    if (Portfolio[security.Ticker].Invested == false)
                    {
                        SetHoldings(security.Ticker, 0.95m / (decimal)sortedStocks.Count);
                        highestPrice[Securities[security.Ticker].Symbol.Value] = Securities[security.Ticker].Close;
                    }
                }
            }
        }

        public class StockData
        {
            public string Ticker;
            public decimal[] Changes1;
            public decimal[] Changes2;
            public decimal Fitness;
        }

        public override void OnSecuritiesChanged(SecurityChanges changes)
        {
            securityChanges = changes;
            foreach (var security in securityChanges.RemovedSecurities)
            {
                List<StockData> stockDatas = highDollarVolumeStocks.Where(x => x.Ticker == security.Symbol).ToList();
                if (stockDatas.Count >= 1)
                {
                    highDollarVolumeStocks.Remove(stockDatas.First());
                }
            }
            foreach (var security in securityChanges.AddedSecurities)
            {
                StockData stockData = new StockData();
                stockData.Ticker = security.Symbol;
                highDollarVolumeStocks.Add(stockData);
            }
            securityChanges = SecurityChanges.None;
        }

        public static decimal[] Changes(decimal[] values)
        {
            List<decimal> lOut = new List<decimal>();
            for (int i = 0; i < values.Length - 1; i++)
            {
                lOut.Add(values[i + 1] - values[i]);
            }
            return lOut.ToArray();
        }

        public static decimal[] ChangesPercent(decimal[] values)
        {
            List<decimal> lOut = new List<decimal>();
            for (int i = 0; i < values.Length - 1; i++)
            {
                lOut.Add((values[i + 1] - values[i]) / values[i]);
            }
            return lOut.ToArray();
        }
    }
}