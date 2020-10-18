//Copyright Warren Harding 2016.
//Granted to the public domain.
//Use entirely at your own risk.
//Custom algorithm development: warrencharding@yahoo.com.
//Do not remove this copyright notice.

using System;
using System.Collections.Generic;
using QuantConnect.Algorithm;
using QuantConnect.Brokerages;
using QuantConnect.Data.Market;
using QuantConnect.Indicators;
using QuantConnect.Orders;
using QuantConnect.Orders.Fees;
using QuantConnect.Orders.Fills;
using QuantConnect.Orders.Slippage;
using QuantConnect.Securities;
namespace QuantConnect
{
    public class Algo3 : QCAlgorithm
    {
        int MompPeriod = 30;
        decimal momentumCutoff = -10;
        decimal ratioOfLastMinuteForMaxTrade = 0.05m;
        TradeBars lastData = null;
        int quantity = 0;
        TradeBar lastBar = null;
        decimal minimumPurchase = 500m;
        Dictionary<string, MomentumPercent> moms = new Dictionary<string, MomentumPercent>();
        public override void Initialize()
        {
            //Start and End Date range for the backtest:
            //SetStartDate(2015, 1, 1);
            //SetEndDate(DateTime.Now.Date.AddDays(-1));

            SetStartDate(2016, 1, 1);
            SetEndDate(2016, 5, 1);

            SetCash(25000);

            //volatile etf's
            string tickersString = "UVXY,XIV,NUGT,DUST,JNUG,JDUST,LABU,LABD,GUSH,DRIP,TVIX,GASL,GASX,DWTI,UWTI,DGAZ,UGAZ,UBIO,ZBIO,BRZU,RUSS,SCO,UCO,RUSL,ERY,ERX,BIOL,SVXY,VXX,SILJ,BIB,BIS,VIXY,SOXL,VIIX,SOXS,BZQ,USLV,SLVP,DSLV,GDXJ,GLDX";

            //gold
            //string tickersString="NUGT,DUST,JNUG,JDUST";

            //68 biggest companies ranked by market cap.
            //string tickersString="AAPL,GOOGL,GOOG,MSFT,XOM,BRK.A,BRK.B,FB,AMZN,JNJ,GE,WFC,T,NSRGY,CHL,JPM,RHHBY,PG,RDS.B,RDS.A,WMT,VZ,PFE,BUD,KO,BABA,CVX,TCEHY,SPY,NVS,V,DIS,HD,ORCL,TM,SSNLF,PM,MRK,BAC,PEP,CMCSA,NVO,INTC,IBM,CSCO,C,PTR,HSBC,UNH,MO,TSM,BMY,GILD,AMGN,TOT,SLB,RLNIY,MCD,MDT,CVS,MA,SNY,GSK,BTI,BP,LRLCY,MMM,IDEXY";

            string[] tickers = tickersString.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ticker in tickers)
            {
                AddSecurity(SecurityType.Equity, ticker, Resolution.Minute);
            }
            SetBrokerageModel(BrokerageName.Alpaca, AccountType.Margin);

            foreach (Security s in Securities.Values)
            {
                moms.Add(s.Symbol, MOMP(s.Symbol, MompPeriod));
            }
        }

        public void OnData(TradeBars data)
        {
            decimal maxTrade;
            if (lastData != null)
            {
                foreach (TradeBar bar in data.Values)
                {
                    if (Portfolio.Cash < minimumPurchase)
                    {
                        break;
                    }
                    if (!Portfolio[bar.Symbol].HoldStock)
                    {
                        if (lastData.ContainsKey(bar.Symbol))
                        {
                            maxTrade = bar.Close * bar.Volume / ratioOfLastMinuteForMaxTrade;
                            quantity = (int)Math.Floor(Math.Min(Portfolio.Cash, maxTrade) / bar.Close);
                            lastBar = lastData[bar.Symbol];
                            if (quantity * bar.Close > minimumPurchase & quantity > 0)
                            {
                                if (moms[bar.Symbol] < momentumCutoff & bar.Close > lastBar.Close)
                                {
                                    Order(bar.Symbol, quantity);
                                }
                            }
                        }

                    }
                }
                TradeBar bar2;
                foreach (SecurityHolding stock in Portfolio.Values)
                {
                    if (Portfolio[stock.Symbol].Quantity > 0 & lastData.ContainsKey(stock.Symbol) & Portfolio.ContainsKey(stock.Symbol) & data.ContainsKey(stock.Symbol))
                    {
                        lastBar = lastData[stock.Symbol];
                        bar2 = data[stock.Symbol];
                        if (bar2.Close < lastBar.Close)
                        {
                            Order(stock.Symbol, -Portfolio[stock.Symbol].Quantity);
                        }
                    }
                }
            }
            lastData = data;
        }
    }



}