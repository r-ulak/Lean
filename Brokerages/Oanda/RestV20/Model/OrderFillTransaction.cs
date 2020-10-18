/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.15
 * Contact: api@oanda.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// An OrderFillTransaction represents the filling of an Order in the client&#39;s Account.
    /// </summary>
    [DataContract]
    public partial class OrderFillTransaction :  IEquatable<OrderFillTransaction>, IValidatableObject
    {
        /// <summary>
        /// The Type of the Transaction. Always set to \"ORDER_FILL\" for an OrderFillTransaction.
        /// </summary>
        /// <value>The Type of the Transaction. Always set to \"ORDER_FILL\" for an OrderFillTransaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum CREATE for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            CREATE,
            
            /// <summary>
            /// Enum CLOSE for "CLOSE"
            /// </summary>
            [EnumMember(Value = "CLOSE")]
            CLOSE,
            
            /// <summary>
            /// Enum REOPEN for "REOPEN"
            /// </summary>
            [EnumMember(Value = "REOPEN")]
            REOPEN,
            
            /// <summary>
            /// Enum CLIENTCONFIGURE for "CLIENT_CONFIGURE"
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE")]
            CLIENTCONFIGURE,
            
            /// <summary>
            /// Enum CLIENTCONFIGUREREJECT for "CLIENT_CONFIGURE_REJECT"
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE_REJECT")]
            CLIENTCONFIGUREREJECT,
            
            /// <summary>
            /// Enum TRANSFERFUNDS for "TRANSFER_FUNDS"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS")]
            TRANSFERFUNDS,
            
            /// <summary>
            /// Enum TRANSFERFUNDSREJECT for "TRANSFER_FUNDS_REJECT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS_REJECT")]
            TRANSFERFUNDSREJECT,
            
            /// <summary>
            /// Enum MARKETORDER for "MARKET_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER")]
            MARKETORDER,
            
            /// <summary>
            /// Enum MARKETORDERREJECT for "MARKET_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_REJECT")]
            MARKETORDERREJECT,
            
            /// <summary>
            /// Enum LIMITORDER for "LIMIT_ORDER"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER")]
            LIMITORDER,
            
            /// <summary>
            /// Enum LIMITORDERREJECT for "LIMIT_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER_REJECT")]
            LIMITORDERREJECT,
            
            /// <summary>
            /// Enum STOPORDER for "STOP_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER")]
            STOPORDER,
            
            /// <summary>
            /// Enum STOPORDERREJECT for "STOP_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER_REJECT")]
            STOPORDERREJECT,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDER for "MARKET_IF_TOUCHED_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
            MARKETIFTOUCHEDORDER,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDERREJECT for "MARKET_IF_TOUCHED_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER_REJECT")]
            MARKETIFTOUCHEDORDERREJECT,
            
            /// <summary>
            /// Enum TAKEPROFITORDER for "TAKE_PROFIT_ORDER"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER")]
            TAKEPROFITORDER,
            
            /// <summary>
            /// Enum TAKEPROFITORDERREJECT for "TAKE_PROFIT_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER_REJECT")]
            TAKEPROFITORDERREJECT,
            
            /// <summary>
            /// Enum STOPLOSSORDER for "STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER")]
            STOPLOSSORDER,
            
            /// <summary>
            /// Enum STOPLOSSORDERREJECT for "STOP_LOSS_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER_REJECT")]
            STOPLOSSORDERREJECT,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDER for "TRAILING_STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
            TRAILINGSTOPLOSSORDER,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDERREJECT for "TRAILING_STOP_LOSS_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER_REJECT")]
            TRAILINGSTOPLOSSORDERREJECT,
            
            /// <summary>
            /// Enum ORDERFILL for "ORDER_FILL"
            /// </summary>
            [EnumMember(Value = "ORDER_FILL")]
            ORDERFILL,
            
            /// <summary>
            /// Enum ORDERCANCEL for "ORDER_CANCEL"
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL")]
            ORDERCANCEL,
            
            /// <summary>
            /// Enum ORDERCANCELREJECT for "ORDER_CANCEL_REJECT"
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL_REJECT")]
            ORDERCANCELREJECT,
            
            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFY for "ORDER_CLIENT_EXTENSIONS_MODIFY"
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY")]
            ORDERCLIENTEXTENSIONSMODIFY,
            
            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFYREJECT for "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT"
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            ORDERCLIENTEXTENSIONSMODIFYREJECT,
            
            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFY for "TRADE_CLIENT_EXTENSIONS_MODIFY"
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY")]
            TRADECLIENTEXTENSIONSMODIFY,
            
            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFYREJECT for "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT"
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            TRADECLIENTEXTENSIONSMODIFYREJECT,
            
            /// <summary>
            /// Enum MARGINCALLENTER for "MARGIN_CALL_ENTER"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_ENTER")]
            MARGINCALLENTER,
            
            /// <summary>
            /// Enum MARGINCALLEXTEND for "MARGIN_CALL_EXTEND"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXTEND")]
            MARGINCALLEXTEND,
            
            /// <summary>
            /// Enum MARGINCALLEXIT for "MARGIN_CALL_EXIT"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXIT")]
            MARGINCALLEXIT,
            
            /// <summary>
            /// Enum DELAYEDTRADECLOSURE for "DELAYED_TRADE_CLOSURE"
            /// </summary>
            [EnumMember(Value = "DELAYED_TRADE_CLOSURE")]
            DELAYEDTRADECLOSURE,
            
            /// <summary>
            /// Enum DAILYFINANCING for "DAILY_FINANCING"
            /// </summary>
            [EnumMember(Value = "DAILY_FINANCING")]
            DAILYFINANCING,
            
            /// <summary>
            /// Enum RESETRESETTABLEPL for "RESET_RESETTABLE_PL"
            /// </summary>
            [EnumMember(Value = "RESET_RESETTABLE_PL")]
            RESETRESETTABLEPL
        }

        /// <summary>
        /// The reason that an Order was filled
        /// </summary>
        /// <value>The reason that an Order was filled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum LIMITORDER for "LIMIT_ORDER"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER")]
            LIMITORDER,
            
            /// <summary>
            /// Enum STOPORDER for "STOP_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER")]
            STOPORDER,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDER for "MARKET_IF_TOUCHED_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
            MARKETIFTOUCHEDORDER,
            
            /// <summary>
            /// Enum TAKEPROFITORDER for "TAKE_PROFIT_ORDER"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER")]
            TAKEPROFITORDER,
            
            /// <summary>
            /// Enum STOPLOSSORDER for "STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER")]
            STOPLOSSORDER,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDER for "TRAILING_STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
            TRAILINGSTOPLOSSORDER,
            
            /// <summary>
            /// Enum MARKETORDER for "MARKET_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER")]
            MARKETORDER,
            
            /// <summary>
            /// Enum MARKETORDERTRADECLOSE for "MARKET_ORDER_TRADE_CLOSE"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_TRADE_CLOSE")]
            MARKETORDERTRADECLOSE,
            
            /// <summary>
            /// Enum MARKETORDERPOSITIONCLOSEOUT for "MARKET_ORDER_POSITION_CLOSEOUT"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_POSITION_CLOSEOUT")]
            MARKETORDERPOSITIONCLOSEOUT,
            
            /// <summary>
            /// Enum MARKETORDERMARGINCLOSEOUT for "MARKET_ORDER_MARGIN_CLOSEOUT"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_MARGIN_CLOSEOUT")]
            MARKETORDERMARGINCLOSEOUT,
            
            /// <summary>
            /// Enum MARKETORDERDELAYEDTRADECLOSE for "MARKET_ORDER_DELAYED_TRADE_CLOSE"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_DELAYED_TRADE_CLOSE")]
            MARKETORDERDELAYEDTRADECLOSE
        }

        /// <summary>
        /// The Type of the Transaction. Always set to \"ORDER_FILL\" for an OrderFillTransaction.
        /// </summary>
        /// <value>The Type of the Transaction. Always set to \"ORDER_FILL\" for an OrderFillTransaction.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The reason that an Order was filled
        /// </summary>
        /// <value>The reason that an Order was filled</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFillTransaction" /> class.
        /// </summary>
        /// <param name="Id">The Transaction&#39;s Identifier..</param>
        /// <param name="Time">The date/time when the Transaction was created..</param>
        /// <param name="UserID">The ID of the user that initiated the creation of the Transaction..</param>
        /// <param name="AccountID">The ID of the Account the Transaction was created for..</param>
        /// <param name="BatchID">The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously..</param>
        /// <param name="RequestID">The Request ID of the request which generated the transaction..</param>
        /// <param name="Type">The Type of the Transaction. Always set to \&quot;ORDER_FILL\&quot; for an OrderFillTransaction..</param>
        /// <param name="OrderID">The ID of the Order filled..</param>
        /// <param name="ClientOrderID">The client Order ID of the Order filled (only provided if the client has assigned one)..</param>
        /// <param name="Instrument">The name of the filled Order&#39;s instrument..</param>
        /// <param name="Units">The number of units filled by the Order..</param>
        /// <param name="Price">The average market price that the Order was filled at..</param>
        /// <param name="Reason">The reason that an Order was filled.</param>
        /// <param name="Pl">The profit or loss incurred when the Order was filled..</param>
        /// <param name="Financing">The financing paid or collected when the Order was filled..</param>
        /// <param name="AccountBalance">The Account&#39;s balance after the Order was filled..</param>
        /// <param name="TradeOpened">TradeOpened.</param>
        /// <param name="TradesClosed">The Trades that were closed when the Order was filled (only provided if filling the Order resulted in a closing open Trades)..</param>
        /// <param name="TradeReduced">TradeReduced.</param>
        public OrderFillTransaction(string Id = default(string), string Time = default(string), int? UserID = default(int?), string AccountID = default(string), string BatchID = default(string), string RequestID = default(string), TypeEnum? Type = default(TypeEnum?), string OrderID = default(string), string ClientOrderID = default(string), string Instrument = default(string), string Units = default(string), string Price = default(string), ReasonEnum? Reason = default(ReasonEnum?), string Pl = default(string), string Financing = default(string), string AccountBalance = default(string), TradeOpen TradeOpened = default(TradeOpen), List<TradeReduce> TradesClosed = default(List<TradeReduce>), TradeReduce TradeReduced = default(TradeReduce))
        {
            this.Id = Id;
            this.Time = Time;
            this.UserID = UserID;
            this.AccountID = AccountID;
            this.BatchID = BatchID;
            this.RequestID = RequestID;
            this.Type = Type;
            this.OrderID = OrderID;
            this.ClientOrderID = ClientOrderID;
            this.Instrument = Instrument;
            this.Units = Units;
            this.Price = Price;
            this.Reason = Reason;
            this.Pl = Pl;
            this.Financing = Financing;
            this.AccountBalance = AccountBalance;
            this.TradeOpened = TradeOpened;
            this.TradesClosed = TradesClosed;
            this.TradeReduced = TradeReduced;
        }
        
        /// <summary>
        /// The Transaction&#39;s Identifier.
        /// </summary>
        /// <value>The Transaction&#39;s Identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The date/time when the Transaction was created.
        /// </summary>
        /// <value>The date/time when the Transaction was created.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }
        /// <summary>
        /// The ID of the user that initiated the creation of the Transaction.
        /// </summary>
        /// <value>The ID of the user that initiated the creation of the Transaction.</value>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int? UserID { get; set; }
        /// <summary>
        /// The ID of the Account the Transaction was created for.
        /// </summary>
        /// <value>The ID of the Account the Transaction was created for.</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public string AccountID { get; set; }
        /// <summary>
        /// The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.
        /// </summary>
        /// <value>The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.</value>
        [DataMember(Name="batchID", EmitDefaultValue=false)]
        public string BatchID { get; set; }
        /// <summary>
        /// The Request ID of the request which generated the transaction.
        /// </summary>
        /// <value>The Request ID of the request which generated the transaction.</value>
        [DataMember(Name="requestID", EmitDefaultValue=false)]
        public string RequestID { get; set; }
        /// <summary>
        /// The ID of the Order filled.
        /// </summary>
        /// <value>The ID of the Order filled.</value>
        [DataMember(Name="orderID", EmitDefaultValue=false)]
        public string OrderID { get; set; }
        /// <summary>
        /// The client Order ID of the Order filled (only provided if the client has assigned one).
        /// </summary>
        /// <value>The client Order ID of the Order filled (only provided if the client has assigned one).</value>
        [DataMember(Name="clientOrderID", EmitDefaultValue=false)]
        public string ClientOrderID { get; set; }
        /// <summary>
        /// The name of the filled Order&#39;s instrument.
        /// </summary>
        /// <value>The name of the filled Order&#39;s instrument.</value>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public string Instrument { get; set; }
        /// <summary>
        /// The number of units filled by the Order.
        /// </summary>
        /// <value>The number of units filled by the Order.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }
        /// <summary>
        /// The average market price that the Order was filled at.
        /// </summary>
        /// <value>The average market price that the Order was filled at.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }
        /// <summary>
        /// The profit or loss incurred when the Order was filled.
        /// </summary>
        /// <value>The profit or loss incurred when the Order was filled.</value>
        [DataMember(Name="pl", EmitDefaultValue=false)]
        public string Pl { get; set; }
        /// <summary>
        /// The financing paid or collected when the Order was filled.
        /// </summary>
        /// <value>The financing paid or collected when the Order was filled.</value>
        [DataMember(Name="financing", EmitDefaultValue=false)]
        public string Financing { get; set; }
        /// <summary>
        /// The Account&#39;s balance after the Order was filled.
        /// </summary>
        /// <value>The Account&#39;s balance after the Order was filled.</value>
        [DataMember(Name="accountBalance", EmitDefaultValue=false)]
        public string AccountBalance { get; set; }
        /// <summary>
        /// Gets or Sets TradeOpened
        /// </summary>
        [DataMember(Name="tradeOpened", EmitDefaultValue=false)]
        public TradeOpen TradeOpened { get; set; }
        /// <summary>
        /// The Trades that were closed when the Order was filled (only provided if filling the Order resulted in a closing open Trades).
        /// </summary>
        /// <value>The Trades that were closed when the Order was filled (only provided if filling the Order resulted in a closing open Trades).</value>
        [DataMember(Name="tradesClosed", EmitDefaultValue=false)]
        public List<TradeReduce> TradesClosed { get; set; }
        /// <summary>
        /// Gets or Sets TradeReduced
        /// </summary>
        [DataMember(Name="tradeReduced", EmitDefaultValue=false)]
        public TradeReduce TradeReduced { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFillTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  BatchID: ").Append(BatchID).Append("\n");
            sb.Append("  RequestID: ").Append(RequestID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OrderID: ").Append(OrderID).Append("\n");
            sb.Append("  ClientOrderID: ").Append(ClientOrderID).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Pl: ").Append(Pl).Append("\n");
            sb.Append("  Financing: ").Append(Financing).Append("\n");
            sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
            sb.Append("  TradeOpened: ").Append(TradeOpened).Append("\n");
            sb.Append("  TradesClosed: ").Append(TradesClosed).Append("\n");
            sb.Append("  TradeReduced: ").Append(TradeReduced).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderFillTransaction);
        }

        /// <summary>
        /// Returns true if OrderFillTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderFillTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFillTransaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.UserID == other.UserID ||
                    this.UserID != null &&
                    this.UserID.Equals(other.UserID)
                ) && 
                (
                    this.AccountID == other.AccountID ||
                    this.AccountID != null &&
                    this.AccountID.Equals(other.AccountID)
                ) && 
                (
                    this.BatchID == other.BatchID ||
                    this.BatchID != null &&
                    this.BatchID.Equals(other.BatchID)
                ) && 
                (
                    this.RequestID == other.RequestID ||
                    this.RequestID != null &&
                    this.RequestID.Equals(other.RequestID)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.OrderID == other.OrderID ||
                    this.OrderID != null &&
                    this.OrderID.Equals(other.OrderID)
                ) && 
                (
                    this.ClientOrderID == other.ClientOrderID ||
                    this.ClientOrderID != null &&
                    this.ClientOrderID.Equals(other.ClientOrderID)
                ) && 
                (
                    this.Instrument == other.Instrument ||
                    this.Instrument != null &&
                    this.Instrument.Equals(other.Instrument)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.Equals(other.Units)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Pl == other.Pl ||
                    this.Pl != null &&
                    this.Pl.Equals(other.Pl)
                ) && 
                (
                    this.Financing == other.Financing ||
                    this.Financing != null &&
                    this.Financing.Equals(other.Financing)
                ) && 
                (
                    this.AccountBalance == other.AccountBalance ||
                    this.AccountBalance != null &&
                    this.AccountBalance.Equals(other.AccountBalance)
                ) && 
                (
                    this.TradeOpened == other.TradeOpened ||
                    this.TradeOpened != null &&
                    this.TradeOpened.Equals(other.TradeOpened)
                ) && 
                (
                    this.TradesClosed == other.TradesClosed ||
                    this.TradesClosed != null &&
                    this.TradesClosed.SequenceEqual(other.TradesClosed)
                ) && 
                (
                    this.TradeReduced == other.TradeReduced ||
                    this.TradeReduced != null &&
                    this.TradeReduced.Equals(other.TradeReduced)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.UserID != null)
                    hash = hash * 59 + this.UserID.GetHashCode();
                if (this.AccountID != null)
                    hash = hash * 59 + this.AccountID.GetHashCode();
                if (this.BatchID != null)
                    hash = hash * 59 + this.BatchID.GetHashCode();
                if (this.RequestID != null)
                    hash = hash * 59 + this.RequestID.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.OrderID != null)
                    hash = hash * 59 + this.OrderID.GetHashCode();
                if (this.ClientOrderID != null)
                    hash = hash * 59 + this.ClientOrderID.GetHashCode();
                if (this.Instrument != null)
                    hash = hash * 59 + this.Instrument.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Pl != null)
                    hash = hash * 59 + this.Pl.GetHashCode();
                if (this.Financing != null)
                    hash = hash * 59 + this.Financing.GetHashCode();
                if (this.AccountBalance != null)
                    hash = hash * 59 + this.AccountBalance.GetHashCode();
                if (this.TradeOpened != null)
                    hash = hash * 59 + this.TradeOpened.GetHashCode();
                if (this.TradesClosed != null)
                    hash = hash * 59 + this.TradesClosed.GetHashCode();
                if (this.TradeReduced != null)
                    hash = hash * 59 + this.TradeReduced.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
