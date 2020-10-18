
using System;
using System.Collections.Generic;
using System.Linq;
using NodaTime;
using QuantConnect.Algorithm.Framework.Selection;
using QuantConnect.Brokerages;
using QuantConnect.Data.Market;
using QuantConnect.Orders;
using QuantConnect.Securities;

namespace QuantConnect.Algorithm.CSharp
{
    public class RobinHoodAlgorithm : QCAlgorithm
    {
        // the changes from the previous universe selection
        private readonly Dictionary<DateTime, List<string>> _backtestSymbolsPerDay = new Dictionary<DateTime, List<string>>();
        private const string LiveUrl = @"https://www.dropbox.com/sh/giil7qdwu1lim41/AACSGsg-U3M2KbO9nTI1nE0fa/stock-picker-live.csv?dl=1";
        private const string BacktestUrl = @"https://www.dropbox.com/sh/giil7qdwu1lim41/AAAXX_ECAFTqxkSIPHmlhCj-a/stock-picker-backtest-2020-10-16.csv?dl=1";
        private Dictionary<string, SecurityDetail> _securityDetails;
        private decimal _stopLossPercent = 0.98m;  //2% trailing loss
        private decimal _maxProfit = 1.02m;  //2% Profit
        decimal minimumPurchase = 500m;

        public override void Initialize()
        {
            UniverseSettings.Resolution = Resolution.Minute;
            SetBrokerageModel(BrokerageName.Alpaca, AccountType.Margin);

            SetStartDate(2020, 10, 16);
            SetEndDate(2030, 10, 16);
            SetCash(100000);
            SetTimeZone("America/New_York");

            //Transactions.MarketOrderFillTimeout = TimeSpan.FromSeconds(30);
            _securityDetails = new Dictionary<string, SecurityDetail>();
            SetUniverseSelection(
                new ScheduledUniverseSelectionModel(
                    DateRules.EveryDay(),
                    TimeRules.At(9, 25),
                    SelectSymbols
                )
            );


            Schedule.On(
                DateRules.EveryDay(),
                // 15 minutes before market close,
                TimeRules.At(3, 45),
                () =>
                {
                    // before market close we Liquidate ALL
                    Liquidate();
                    _securityDetails = new Dictionary<string, SecurityDetail>();
                }
            );
        }



        private IEnumerable<Symbol> SelectSymbols(DateTime dateTime)
        {
            var url = LiveMode ? LiveUrl : BacktestUrl;
            var file = Download(url);
            if (LiveMode)
            {
                // fetch the file from dropbox
                // if we have a file for today, break apart by commas and return symbols
                if (file.Length > 0) return file.ToCsv().Select(x => QuantConnect.Symbol.Create(x, SecurityType.Equity, Market.USA));
                // no symbol today, leave universe unchanged
                return Universe.Unchanged;
            }

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
                return result.Select(x => QuantConnect.Symbol.Create(x, SecurityType.Equity, Market.USA)); ;
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
                    _securityDetails[bar.Symbol.Value] = new SecurityDetail();
                }

                _securityDetails[bar.Symbol.Value].TradeBar = bar;
                if (Portfolio.Cash < minimumPurchase )
                {
                    break;
                }

                if (!Portfolio[bar.Symbol].HoldStock)
                {
                    if (_securityDetails[bar.Symbol.Value].HoldingQuantity == 0)  //there was no holding today
                    {
                        if (bar.High == bar.Close && bar.Open < bar.Price)
                        {
                            // reached the highest for the day
                            //10% in cash
                            SetHoldings(bar.Symbol, 0.9 / Securities.Count);
                            Debug($"{bar.Symbol}  {bar.High}  {bar.Close} {bar.Price} {bar.Open}");
                        }
                    }
                }
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
                    var orderTicket = securityDetail.StopTrailingLossOrderTicket;
                    orderTicket.Update(new UpdateOrderFields()
                    {
                        StopPrice = _stopLossPercent * securityDetail.TradeBar.High
                    });
                }
                else
                {
                    _securityDetails[orderEvent.Symbol.Value].StopTrailingLossOrderTicket
                        = StopMarketOrder(orderEvent.Symbol,
                            -Portfolio[orderEvent.Symbol].Quantity,
                            _securityDetails[orderEvent.Symbol.Value].TradeBar.High * _stopLossPercent);

                    _securityDetails[orderEvent.Symbol.Value].FillPrice = orderEvent.FillPrice;
                    _securityDetails[orderEvent.Symbol.Value].HoldingQuantity = orderEvent.Quantity;
                    _securityDetails[orderEvent.Symbol.Value].StoLimit = LimitOrder(
                        orderEvent.Symbol,
                        -Portfolio[orderEvent.Symbol].Quantity,
                        _securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit);
                    Debug($"{orderEvent.Symbol} filled@ { orderEvent.FillPrice} " +
                          $"qty  {orderEvent.Quantity} " +
                          $"sell@ {_securityDetails[orderEvent.Symbol.Value].FillPrice * _maxProfit} " +
                          $"stopLoss@ {_securityDetails[orderEvent.Symbol.Value].TradeBar.High * _stopLossPercent}");
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
        public decimal FillPrice { get; set; }
        public TradeBar TradeBar { get; set; }
        public decimal HoldingQuantity { get; set; }
        public OrderTicket StopTrailingLossOrderTicket { get; set; }
        public OrderTicket StoLimit { get; set; }
    }
}

