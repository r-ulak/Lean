
using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Algorithm.Framework.Selection;
using QuantConnect.Brokerages;
using QuantConnect.Data.Market;
using QuantConnect.Data.UniverseSelection;
using QuantConnect.Indicators;
using QuantConnect.Orders;

namespace QuantConnect.Algorithm.CSharp
{
    public class RobinHoodAlgorithm : QCAlgorithm
    {
        // the changes from the previous universe selection
        private readonly Dictionary<DateTime, List<string>> _backtestSymbolsPerDay = new Dictionary<DateTime, List<string>>();
        //private const string fileUrl = @"https://www.dropbox.com/s/hu3gwvg8la16cha/stock-picker-live-30.csv?dl=1";
        //private const string fileUrl = @"https://www.dropbox.com/s/msucmgevw0dp0ep/stock-picker-live-45.csv?dl=1";
        private const string fileUrl = @"https://www.dropbox.com/s/rc7xay8voo7elol/stock-picker-backtest-2020-10-16.csv?dl=1";
        private Dictionary<string, SecurityDetail> _securityDetails;
        private decimal _stopLossPercent = 0.98m;  //2% trailing loss
        private decimal _maxProfit = 1.011m;  //1.10% Profit
        decimal minimumPurchase = 500m;
        private int _momentumPeriod = 60;
        private int _priceIncreaseFrequency = 3;
        private int _startHour = 9;
        private int _startMin = 30;
        private bool _tradeDataAvailable = false;
        private decimal _percentBelowDailyHigh = 0.02m;

        public override void Initialize()
        {
            UniverseSettings.Resolution = Resolution.Second;
            SetBrokerageModel(BrokerageName.InteractiveBrokersBrokerage, AccountType.Margin);

            SetStartDate(2020, 10, 12);
            SetEndDate(2020, 10, 16);
            SetCash(100000);
            SetTimeZone("America/New_York");

            //Transactions.MarketOrderFillTimeout = TimeSpan.FromSeconds(30);
            _securityDetails = new Dictionary<string, SecurityDetail>();
            SetUniverseSelection(
                new ScheduledUniverseSelectionModel(
                    DateRules.EveryDay(),
                    TimeRules.At(_startHour, _startMin - 1),
                    SelectSymbols
                )
            );


            Schedule.On(
                DateRules.EveryDay(),
                // 15 minutes before market close,
                TimeRules.At(15, 45),
                () =>
                {
                    // before market close we Liquidate ALL
                    Liquidate();

                }
            );
            Schedule.On(
                DateRules.EveryDay(),

                TimeRules.At(18, 45),
                () =>
                {

                    _securityDetails = new Dictionary<string, SecurityDetail>();
                    _backtestSymbolsPerDay.Clear();
                    UniverseManager.Clear();
                }
            );
        }

        public override void OnSecuritiesChanged(SecurityChanges changes)
        {
            Debug($"OnSecuritiesChanged {Time}: {changes}");
            Debug($" added {string.Join(",", changes.AddedSecurities.Select(x => x.Symbol.Value))}");
            Debug($" removed {string.Join(",", changes.RemovedSecurities.Select(x => x.Symbol.Value))}");
        }


        private IEnumerable<Symbol> SelectSymbols(DateTime dateTime)
        {
            var file = Download(fileUrl);
            _backtestSymbolsPerDay.Clear();
            UniverseManager.Clear();
            foreach (var line in file.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var csv = line.ToCsv();
                var date = DateTime.ParseExact(csv[0], "yyyyMMdd", null);
                var symbols = csv.Skip(1).ToList();
                if (_backtestSymbolsPerDay.ContainsKey(date))
                {
                    _backtestSymbolsPerDay[date].AddRange(symbols);
                }
                else
                {
                    _backtestSymbolsPerDay[date] = symbols;
                }

            }

            List<string> result;
            if (_backtestSymbolsPerDay.TryGetValue(dateTime.Date, out result))
            {
                var response = result.Distinct().
                    Select(x => QuantConnect.Symbol.Create(x, SecurityType.Equity, Market.USA));
                Debug($"*******{dateTime} {string.Join(",", response)}");
                foreach (var key in response)
                {
                    SecurityDetail securityDetail;
                    if (!_securityDetails.TryGetValue(key.Value, out securityDetail))
                    {
                        _securityDetails[key.Value] = new SecurityDetail()
                        {
                            TradeBars = new List<TradeBar>()
                        };
                    }
                    _tradeDataAvailable = true;
                }
                return response;
            }
            _tradeDataAvailable = false;
            return new List<Symbol>() { };
        }

        public void OnData(TradeBars data)
        {
            if (!_tradeDataAvailable) return;

            foreach (TradeBar bar in data.Values)
            {
                if (!(bar.Time.Hour > _startHour && bar.Time.Minute >= _startMin)) return;
                var dailyHigh = Identity(bar.Symbol, Resolution.Daily, Field.High);
                if (dailyHigh==0) return;
                if (!Portfolio[bar.Symbol].HoldStock && Portfolio.Cash > minimumPurchase && _securityDetails.ContainsKey(bar.Symbol.Value))
                {
                    var tradeBars = _securityDetails[bar.Symbol.Value].TradeBars;
                    if (_securityDetails[bar.Symbol.Value].HoldingQuantity == 0)  //there was no holding today
                    {
                        if (tradeBars.Count == 0)
                        {
                            tradeBars.Add(bar);
                            break;
                        }

                        if (tradeBars.Last().High <= bar.High)
                        {
                            tradeBars.Add(bar);
                        }
                        else
                        {
                            tradeBars.Clear();
                            break;
                        }

                        if (tradeBars.Count > _momentumPeriod)
                        {
                            if (tradeBars.Select(x => x.High).Distinct().Count() > _priceIncreaseFrequency
                                && (dailyHigh - bar.Close) / dailyHigh <= _percentBelowDailyHigh)
                            {

                                SetHoldings(bar.Symbol, 0.95 / (Securities.Count / 4));
                                _securityDetails[bar.Symbol.Value].HighestPrice = bar.High;
                                Debug($"{tradeBars.Count} price high time {bar.Time} ticker {bar.Symbol.Value} {string.Join(",", tradeBars.Select(x => x.High))}");
                                Debug($"time {bar.Time} ticker {bar.Symbol.Value} high {bar.High} close {bar.Close} open {bar.Open}");

                            }
                            else
                            {

                                tradeBars.Clear();
                                break;
                            }
                        }

                    }

                }
                else
                {
                    if (bar.High > _securityDetails[bar.Symbol.Value].HighestPrice)
                    {
                        _securityDetails[bar.Symbol.Value].HighestPrice = bar.High;
                        UpdateStopTrailingLoss(_securityDetails[bar.Symbol.Value]);
                    }
                }

            }
        }


        private void UpdateStopTrailingLoss(SecurityDetail securityDetail)
        {
            var orderTicket = securityDetail.StopTrailingLossOrderTicket;
            if (orderTicket != null)
            {
                orderTicket.Update(new UpdateOrderFields()
                {
                    StopPrice = _stopLossPercent * securityDetail.HighestPrice
                });
                if (_stopLossPercent * securityDetail.HighestPrice >= securityDetail.FillPrice * _maxProfit)
                {
                    if (securityDetail.StoLimit != null && securityDetail.StoLimit.OrderId > 0)
                    {
                        securityDetail.StoLimit.Cancel();
                    }
                }
                Plot("Data Chart", "Stop Price", orderTicket.Get(OrderField.StopPrice));
            }
        }

        public override void OnOrderEvent(OrderEvent orderEvent)
        {
            if (orderEvent.Status == OrderStatus.Filled && orderEvent.Direction == OrderDirection.Buy)
            {
                SecurityDetail securityDetail;
                if (_securityDetails.TryGetValue(orderEvent.Symbol.Value, out securityDetail)
                    & securityDetail?.StopTrailingLossOrderTicket?.OrderId > 0)
                {

                    UpdateStopTrailingLoss(securityDetail);
                }
                else
                {
                    _securityDetails[orderEvent.Symbol.Value].FillPrice = orderEvent.FillPrice;
                    _securityDetails[orderEvent.Symbol.Value].HoldingQuantity = orderEvent.Quantity;
                    //Only Take Profit if Stop trailing loss is Lower than profit
                    if (_securityDetails[orderEvent.Symbol.Value].HighestPrice * _stopLossPercent
                        < _securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit)
                    {

                        _securityDetails[orderEvent.Symbol.Value].StoLimit = LimitOrder(
                            orderEvent.Symbol,
                            -Portfolio[orderEvent.Symbol].Quantity,
                            _securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit);
                    }


                    _securityDetails[orderEvent.Symbol.Value].StopTrailingLossOrderTicket
                        = StopMarketOrder(orderEvent.Symbol,
                            -Portfolio[orderEvent.Symbol].Quantity,
                            _securityDetails[orderEvent.Symbol.Value].FillPrice * _stopLossPercent);

                    Debug($"{orderEvent.Symbol} filled@ { orderEvent.FillPrice} " +
                          $"qty  {orderEvent.Quantity} " +
                          $"sell@ {_securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit} " +
                          $"stopLoss@ {_securityDetails[orderEvent.Symbol.Value].FillPrice * _stopLossPercent}");
                }
            }
            else if (orderEvent.Status == OrderStatus.Filled && orderEvent.Direction == OrderDirection.Sell
            )
            {
                var order = Transactions.GetOrderById(orderEvent.OrderId);

                if (order.Type == OrderType.Limit || order.Type == OrderType.StopMarket)
                {
                    Transactions.CancelOpenOrders(order.Symbol);
                }
            }
        }

    }
    public class SecurityDetail
    {
        public decimal HighestPrice { get; set; }
        public decimal FillPrice { get; set; }
        public MomentumPercent Momentum { get; set; }
        public List<TradeBar> TradeBars { get; set; }
        public decimal HoldingQuantity { get; set; }
        public OrderTicket StopTrailingLossOrderTicket { get; set; }
        public OrderTicket StoLimit { get; set; }
    }
}

