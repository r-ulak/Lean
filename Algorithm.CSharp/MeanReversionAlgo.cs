//Copyright HardingSoftware.com 2019, granted to the public domain.
//Use at your own risk. Do not remove this copyright notice.

using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Orders;

namespace QuantConnect.Algorithm.CSharp
{
    public class TMA2Algo : QCAlgorithm
    {
        Symbol symbol = QuantConnect.Symbol.Create("Y", SecurityType.Equity, Market.USA);
        int period = 10;
        decimal LimitRatio = 0.5m;
        Resolution resolution = Resolution.Minute;
        TimeSpan orderExpiryTime = new TimeSpan(0, 0, 0, 59);
        int priceDecimals = 2;
        List<TradeBar> history = new List<TradeBar>();
        decimal startCash = 5000;

        public override void Initialize()
        {
            SetStartDate(2018, 8, 14);
            SetEndDate(2019, 8, 14);
            SetCash(startCash);

            AddEquity(symbol, resolution);
        }

        public override void OnData(Slice data)
        {
            CancelExpiredOrders();
            if (data.Bars.ContainsKey(symbol) && data.Bars[symbol] != null)
            {
                history.Add(data.Bars[symbol]);
                if (history.Count > period)
                {
                    history.RemoveAt(0);
                }
                else
                {
                    return;
                }
                decimal tma = TMA2.TriangularCandleAverage(history);
                decimal range = TMA2.FullRange(history);
                decimal buyPrice = tma - LimitRatio * range;
                decimal sellPrice = tma + LimitRatio * range;
                if (Portfolio[symbol].Quantity == 0)
                {
                    buyPrice = Math.Round(buyPrice, priceDecimals);
                    if (buyPrice > 0)
                    {
                        decimal quantity = startCash / buyPrice;
                        if (OrderIsPlaced(symbol, quantity) == false)
                        {
                            Transactions.CancelOpenOrders();
                            LimitOrder(symbol, quantity, buyPrice);
                        }
                    }
                }
                else if (Portfolio[symbol].Quantity > 0)
                {
                    sellPrice = Math.Round(sellPrice, priceDecimals);
                    if (sellPrice > 0)
                    {
                        decimal quantity = -Portfolio[symbol].Quantity;
                        if (OrderIsPlaced(symbol, quantity) == false)
                        {
                            Transactions.CancelOpenOrders();
                            LimitOrder(symbol, quantity, sellPrice);
                        }
                    }
                }
            }
        }

        public bool OrderIsPlaced(Symbol symbol, decimal quantity)
        {
            List<Order> orders = Transactions.GetOpenOrders(symbol);
            foreach (Order order in orders)
            {
                if (order.Symbol == symbol)
                {
                    if (Math.Sign(quantity) == Math.Sign(order.Quantity))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void CancelExpiredOrders()
        {
            List<Order> orders = Transactions.GetOpenOrders();
            foreach (Order order in orders)
            {
                if (Time > order.Time + orderExpiryTime)
                {
                    Transactions.CancelOrder(order.Id);
                }
            }
        }

        public class TMA2
        {
            //Copyright HardingSoftware.com 2019, granted to the public domain.
            //Use at your own risk. Do not remove this copyright notice.

            public static decimal TriangularCandleAverage(List<TradeBar> candles)
            {
                return TriangularMovingAverage(CandleAverages(candles));
            }

            public static decimal[] CandleAverages(List<TradeBar> candles)
            {
                return candles.Select(x => CandleAverage(x)).ToArray();
            }

            public static decimal CandleAverage(TradeBar candle)
            {
                return (candle.Open + candle.High + candle.Low + candle.Close) / 4;
            }

            public static decimal[] TriangularWeightsDecimal(int length)
            {
                int[] intWeights = Enumerable.Range(1, length).ToArray();
                return intWeights.Select(x => Convert.ToDecimal(x)).ToArray();
            }

            public static decimal TriangularMovingAverage(decimal[] values)
            {
                return WeightedAverage(values, TriangularWeightsDecimal(values.Length));
            }

            public static decimal FullRange(List<TradeBar> candles)
            {
                return candles.Select(x => x.High).Max() - candles.Select(x => x.Low).Min();
            }

            public static decimal WeightedAverage(decimal[] values, decimal[] weights)
            {
                return values.Zip(weights, (x, y) => x * y).Sum() / weights.Sum();
            }
        }
    }
}