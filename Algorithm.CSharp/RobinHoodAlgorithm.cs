
using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Algorithm.Framework.Selection;
using QuantConnect.Brokerages;
using QuantConnect.Data.Market;
using QuantConnect.Indicators;
using QuantConnect.Orders;

namespace QuantConnect.Algorithm.CSharp
{
    public class RobinHoodAlgorithm : QCAlgorithm
    {
        // the changes from the previous universe selection
        private readonly Dictionary<DateTime, List<string>> _backtestSymbolsPerDay = new Dictionary<DateTime, List<string>>();
        private const string fileUrl = @"https://www.dropbox.com/s/rc7xay8voo7elol/stock-picker-backtest-2020-10-16.csv?dl=1";
        private Dictionary<string, SecurityDetail> _securityDetails;
        private decimal _stopLossPercent = 0.97m;  //2% trailing loss
        private decimal _maxProfit = 1.02m;  //2% Profit
        decimal minimumPurchase = 500m;
        private int _momentumPeriod = 5;

        public override void Initialize()
        {
            UniverseSettings.Resolution = Resolution.Minute;
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
                    TimeRules.At(9, 40),
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
                }
            );
        }



        private IEnumerable<Symbol> SelectSymbols(DateTime dateTime)
        {
            var file = Download(fileUrl);

            // backtest - first cache the entire file
            if (_backtestSymbolsPerDay.Count == 0)
            {
                // split the file into lines and add to our cache
                foreach (var line in file.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var csv = line.ToCsv();
                    var date = DateTime.ParseExact(csv[0], "yyyyMMdd", null);
                    var symbols = csv.Skip(1).ToList();
                    _backtestSymbolsPerDay[date] = symbols;
                }
            }
            // if we have symbols for this date return them, else specify Universe.Unchanged
            List<string> result;
            if (_backtestSymbolsPerDay.TryGetValue(dateTime.Date, out result))
            {
                var response = result.Select(x => QuantConnect.Symbol.Create(x, SecurityType.Equity, Market.USA));
                return response;
            }
            return Universe.Unchanged;
        }

        public void OnData(TradeBars data)
        {
            foreach (TradeBar bar in data.Values)
            {
                SecurityDetail securityDetail;
                if (!_securityDetails.TryGetValue(bar.Symbol.Value, out securityDetail))
                {
                    _securityDetails[bar.Symbol.Value] = new SecurityDetail()
                    {
                        Momentum = MOMP(bar.Symbol, _momentumPeriod, Resolution.Minute)
                    };
                }
                _securityDetails[bar.Symbol.Value].TradeBar = bar;
                if (Portfolio.Cash < minimumPurchase)
                {
                    break;
                }
                if (bar.High > _securityDetails[bar.Symbol.Value].HighestPrice)
                {
                    _securityDetails[bar.Symbol.Value].HighestPrice = bar.High;
                    UpdateStopTrailingLoss(_securityDetails[bar.Symbol.Value]);
                }
                if (!Portfolio[bar.Symbol].HoldStock)
                {
                    if (_securityDetails[bar.Symbol.Value].HoldingQuantity == 0 && _securityDetails[bar.Symbol.Value].PreviousTradeBar != null)  //there was no holding today
                    {
                        if (bar.High > _securityDetails[bar.Symbol.Value].PreviousTradeBar.High 
                            && bar.Close> _securityDetails[bar.Symbol.Value].PreviousTradeBar.Close)
                        {
                            // reached the highest for the day
                            //10% in cash
                            SetHoldings(bar.Symbol, 0.9 / Securities.Count);
                            Debug($"time {bar.Time} ticker {bar.Symbol.Value} high {bar.High} close {bar.Close} open {bar.Open} mom {_securityDetails[bar.Symbol.Value].Momentum}");

                        }
                    }
                }


                _securityDetails[bar.Symbol.Value].PreviousTradeBar = bar;
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

                    _securityDetails[orderEvent.Symbol.Value].StoLimit = LimitOrder(
                        orderEvent.Symbol,
                        -Portfolio[orderEvent.Symbol].Quantity,
                        _securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit);

                    

                    _securityDetails[orderEvent.Symbol.Value].StopTrailingLossOrderTicket
                        = StopMarketOrder(orderEvent.Symbol,
                            -Portfolio[orderEvent.Symbol].Quantity,
                            _securityDetails[orderEvent.Symbol.Value].HighestPrice * _stopLossPercent);

                    Debug($"{orderEvent.Symbol} filled@ { orderEvent.FillPrice} " +
                          $"qty  {orderEvent.Quantity} " +
                          $"sell@ {_securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit} " +
                          $"stopLoss@ {_securityDetails[orderEvent.Symbol.Value].HighestPrice * _stopLossPercent}");
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
        public TradeBar PreviousTradeBar { get; set; }
        public TradeBar TradeBar { get; set; }
        public decimal HoldingQuantity { get; set; }
        public OrderTicket StopTrailingLossOrderTicket { get; set; }
        public OrderTicket StoLimit { get; set; }
    }
}

