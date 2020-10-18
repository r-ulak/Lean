using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Algorithm.Framework.Selection;
using QuantConnect.Brokerages;
using QuantConnect.Data;
using QuantConnect.Indicators;
using QuantConnect.Orders;

namespace QuantConnect.Algorithm.CSharp
{

    public class AssetClassMomentumAlgorithm : QCAlgorithm
    {

        /// <summary>
        /// Initialise the data and resolution required, as well as the cash and start-end dates for your algorithm. All algorithms must initialized.
        /// </summary>
        private int period = 12 * 21;

        private Dictionary<string, Momentum> _momentum;
        private Dictionary<string, decimal> highestPrice;
        private Dictionary<string, OrderTicket> stopMarketTicket;
        private List<string> _symbols;
        public override void Initialize()
        {
            // Set requested data resolution
            _momentum = new Dictionary<string, Momentum>();
            highestPrice = new Dictionary<string, decimal>();
            stopMarketTicket = new Dictionary<string, OrderTicket>();


            SetStartDate(2019, 1, 16);  //Set Start Date
            SetEndDate(DateTime.Now);    //Set End Date
            SetCash(100000);             //Set Strategy Cash

            // set algorithm framework models
            //SetAlpha(new ConstantAlphaModel(InsightType.Price, InsightDirection.Up, TimeSpan.FromMinutes(20), 0.025, null));
            //SetPortfolioConstruction(new EqualWeightingPortfolioConstructionModel());
            //SetExecution(new ImmediateExecutionModel());
            _symbols = new List<string>()
            {
                "SPY", "EFA", "IETC", "QQQ", "XNTK","SWAN","RWGV","BTAL","CLIX","JKE","PSJ","TMFC","GLD"
            };

            SetWarmUp(period, Resolution.Daily);
            // SetBrokerageModel(BrokerageName.Alpaca, AccountType.Margin);
            foreach (var symbol in _symbols)
            {
                AddEquity(symbol, Resolution.Daily);
                _momentum[symbol] = MOM(symbol, period, Resolution.Daily);
            }

            Schedule.On(DateRules.MonthStart("SPY"), TimeRules.AfterMarketOpen("SPY"), ReBalance);
        }
        public override void OnData(Slice slice)
        {
            //1. Plot the current SPY price to "Data Chart" on series "Asset Price"


            foreach (var kvp in Portfolio)
            {
                var security = kvp.Value.Symbol;

                if (Portfolio[security].Invested)
                {
                    if (Securities[security].Close > highestPrice[security.Value])
                    {
                        highestPrice[security.Value] = Securities[security].Close;
                        OrderTicket orderTicket;
                        if (stopMarketTicket.TryGetValue(security.Value, out orderTicket) & orderTicket.OrderId > 0)
                        {
                            orderTicket.Update(new UpdateOrderFields()
                            {
                                StopPrice = 0.95m * highestPrice[security.Value]
                            });
                        }
                        else
                        {
                            stopMarketTicket[security.Value] = StopMarketOrder(security, -Portfolio[security].Quantity, highestPrice[security.Value] * 0.95m);
                        }
                    }
                }
                highestPrice[security.Value] = Securities[security].Close;
              //  stopMarketTicket[security.Value] = StopMarketOrder(security, -Portfolio[security].Quantity, highestPrice[security.Value] * 0.95m);

            }

        }

        private void ReBalance()
        {
            if (IsWarmingUp) return;
            var top3 =
                (from entry in _momentum orderby entry.Value descending select entry.Key).Take(3);


            foreach (var kvp in Portfolio)
            {
                var secutiyHold = kvp.Value;
                //iquidate the security which is no longer in the top3 momentum list
                if (secutiyHold.Invested && (!top3.Contains(secutiyHold.Symbol.Value)))
                {
                    Liquidate(secutiyHold.Symbol);
                }
            }
            var newSymbols = new List<Symbol>();
            foreach (var symbol in top3)
            {
                Debug("top3 Symbol " + symbol);
                if (!Portfolio[symbol].Invested)
                {
                    newSymbols.Add(symbol);
                }
            }

            foreach (var symbol in newSymbols)
            {
                Debug("new Symbol " + symbol.Value);
                SetHoldings(symbol, 1m / newSymbols.Count);
                highestPrice[symbol.Value] = Securities[symbol].Close;

            }
        }
    }
}