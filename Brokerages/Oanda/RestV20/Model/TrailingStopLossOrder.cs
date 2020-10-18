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
    /// A TrailingStopLossOrder is an order that is linked to an open Trade and created with a price distance. The price distance is used to calculate a trailing stop value for the order that is in the losing direction from the market price at the time of the order&#39;s creation. The trailing stop value will follow the market price as it moves in the winning direction, and the order will filled (closing the Trade) by the first price that is equal to or worse than the trailing stop value. A TrailingStopLossOrder cannot be used to open a new Position.
    /// </summary>
    [DataContract]
    public partial class TrailingStopLossOrder :  IEquatable<TrailingStopLossOrder>, IValidatableObject
    {
        /// <summary>
        /// The current state of the Order.
        /// </summary>
        /// <value>The current state of the Order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum FILLED for "FILLED"
            /// </summary>
            [EnumMember(Value = "FILLED")]
            FILLED,
            
            /// <summary>
            /// Enum TRIGGERED for "TRIGGERED"
            /// </summary>
            [EnumMember(Value = "TRIGGERED")]
            TRIGGERED,
            
            /// <summary>
            /// Enum CANCELLED for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED
        }

        /// <summary>
        /// The type of the Order. Always set to \"TRAILING_STOP_LOSS\" for Trailing Stop Loss Orders.
        /// </summary>
        /// <value>The type of the Order. Always set to \"TRAILING_STOP_LOSS\" for Trailing Stop Loss Orders.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum MARKET for "MARKET"
            /// </summary>
            [EnumMember(Value = "MARKET")]
            MARKET,
            
            /// <summary>
            /// Enum LIMIT for "LIMIT"
            /// </summary>
            [EnumMember(Value = "LIMIT")]
            LIMIT,
            
            /// <summary>
            /// Enum STOP for "STOP"
            /// </summary>
            [EnumMember(Value = "STOP")]
            STOP,
            
            /// <summary>
            /// Enum MARKETIFTOUCHED for "MARKET_IF_TOUCHED"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED")]
            MARKETIFTOUCHED,
            
            /// <summary>
            /// Enum TAKEPROFIT for "TAKE_PROFIT"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT")]
            TAKEPROFIT,
            
            /// <summary>
            /// Enum STOPLOSS for "STOP_LOSS"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS")]
            STOPLOSS,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSS for "TRAILING_STOP_LOSS"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS")]
            TRAILINGSTOPLOSS
        }

        /// <summary>
        /// The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.
        /// </summary>
        /// <value>The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            
            /// <summary>
            /// Enum GTC for "GTC"
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC,
            
            /// <summary>
            /// Enum GTD for "GTD"
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD,
            
            /// <summary>
            /// Enum GFD for "GFD"
            /// </summary>
            [EnumMember(Value = "GFD")]
            GFD,
            
            /// <summary>
            /// Enum FOK for "FOK"
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK,
            
            /// <summary>
            /// Enum IOC for "IOC"
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC
        }

        /// <summary>
        /// Specification of what component of a price should be used for comparison when determining if the Order should be filled.
        /// </summary>
        /// <value>Specification of what component of a price should be used for comparison when determining if the Order should be filled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TriggerConditionEnum
        {
            
            /// <summary>
            /// Enum DEFAULT for "DEFAULT"
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT,
            
            /// <summary>
            /// Enum TRIGGERDEFAULT for "TRIGGER_DEFAULT"
            /// </summary>
            [EnumMember(Value = "TRIGGER_DEFAULT")]
            TRIGGERDEFAULT,
            
            /// <summary>
            /// Enum INVERSE for "INVERSE"
            /// </summary>
            [EnumMember(Value = "INVERSE")]
            INVERSE,
            
            /// <summary>
            /// Enum BID for "BID"
            /// </summary>
            [EnumMember(Value = "BID")]
            BID,
            
            /// <summary>
            /// Enum ASK for "ASK"
            /// </summary>
            [EnumMember(Value = "ASK")]
            ASK,
            
            /// <summary>
            /// Enum MID for "MID"
            /// </summary>
            [EnumMember(Value = "MID")]
            MID
        }

        /// <summary>
        /// The current state of the Order.
        /// </summary>
        /// <value>The current state of the Order.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The type of the Order. Always set to \"TRAILING_STOP_LOSS\" for Trailing Stop Loss Orders.
        /// </summary>
        /// <value>The type of the Order. Always set to \"TRAILING_STOP_LOSS\" for Trailing Stop Loss Orders.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.
        /// </summary>
        /// <value>The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Specification of what component of a price should be used for comparison when determining if the Order should be filled.
        /// </summary>
        /// <value>Specification of what component of a price should be used for comparison when determining if the Order should be filled.</value>
        [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
        public TriggerConditionEnum? TriggerCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrailingStopLossOrder" /> class.
        /// </summary>
        /// <param name="Id">The Order&#39;s identifier, unique within the Order&#39;s Account..</param>
        /// <param name="CreateTime">The time when the Order was created..</param>
        /// <param name="State">The current state of the Order..</param>
        /// <param name="ClientExtensions">ClientExtensions.</param>
        /// <param name="Type">The type of the Order. Always set to \&quot;TRAILING_STOP_LOSS\&quot; for Trailing Stop Loss Orders..</param>
        /// <param name="TradeID">The ID of the Trade to close when the price threshold is breached..</param>
        /// <param name="ClientTradeID">The client ID of the Trade to be closed when the price threshold is breached..</param>
        /// <param name="Distance">The price distance specified for the TrailingStopLoss Order..</param>
        /// <param name="TimeInForce">The time-in-force requested for the TrailingStopLoss Order. Restricted to \&quot;GTC\&quot;, \&quot;GFD\&quot; and \&quot;GTD\&quot; for TrailingStopLoss Orders..</param>
        /// <param name="GtdTime">The date/time when the StopLoss Order will be cancelled if its timeInForce is \&quot;GTD\&quot;..</param>
        /// <param name="TriggerCondition">Specification of what component of a price should be used for comparison when determining if the Order should be filled..</param>
        /// <param name="TrailingStopValue">The trigger price for the Trailing Stop Loss Order. The trailing stop value will trail (follow) the market price by the TSL order&#39;s configured \&quot;distance\&quot; as the market price moves in the winning direction. If the market price moves to a level that is equal to or worse than the trailing stop value, the order will be filled and the Trade will be closed..</param>
        /// <param name="FillingTransactionID">ID of the Transaction that filled this Order (only provided when the Order&#39;s state is FILLED).</param>
        /// <param name="FilledTime">Date/time when the Order was filled (only provided when the Order&#39;s state is FILLED).</param>
        /// <param name="TradeOpenedID">Trade ID of Trade opened when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was opened as a result of the fill).</param>
        /// <param name="TradeReducedID">Trade ID of Trade reduced when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was reduced as a result of the fill).</param>
        /// <param name="TradeClosedIDs">Trade IDs of Trades closed when the Order was filled (only provided when the Order&#39;s state is FILLED and one or more Trades were closed as a result of the fill).</param>
        /// <param name="CancellingTransactionID">ID of the Transaction that cancelled the Order (only provided when the Order&#39;s state is CANCELLED).</param>
        /// <param name="CancelledTime">Date/time when the Order was cancelled (only provided when the state of the Order is CANCELLED).</param>
        /// <param name="ReplacesOrderID">The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace)..</param>
        /// <param name="ReplacedByOrderID">The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace)..</param>
        public TrailingStopLossOrder(string Id = default(string), string CreateTime = default(string), StateEnum? State = default(StateEnum?), ClientExtensions ClientExtensions = default(ClientExtensions), TypeEnum? Type = default(TypeEnum?), string TradeID = default(string), string ClientTradeID = default(string), string Distance = default(string), TimeInForceEnum? TimeInForce = default(TimeInForceEnum?), string GtdTime = default(string), TriggerConditionEnum? TriggerCondition = default(TriggerConditionEnum?), string TrailingStopValue = default(string), string FillingTransactionID = default(string), string FilledTime = default(string), string TradeOpenedID = default(string), string TradeReducedID = default(string), List<string> TradeClosedIDs = default(List<string>), string CancellingTransactionID = default(string), string CancelledTime = default(string), string ReplacesOrderID = default(string), string ReplacedByOrderID = default(string))
        {
            this.Id = Id;
            this.CreateTime = CreateTime;
            this.State = State;
            this.ClientExtensions = ClientExtensions;
            this.Type = Type;
            this.TradeID = TradeID;
            this.ClientTradeID = ClientTradeID;
            this.Distance = Distance;
            this.TimeInForce = TimeInForce;
            this.GtdTime = GtdTime;
            this.TriggerCondition = TriggerCondition;
            this.TrailingStopValue = TrailingStopValue;
            this.FillingTransactionID = FillingTransactionID;
            this.FilledTime = FilledTime;
            this.TradeOpenedID = TradeOpenedID;
            this.TradeReducedID = TradeReducedID;
            this.TradeClosedIDs = TradeClosedIDs;
            this.CancellingTransactionID = CancellingTransactionID;
            this.CancelledTime = CancelledTime;
            this.ReplacesOrderID = ReplacesOrderID;
            this.ReplacedByOrderID = ReplacedByOrderID;
        }
        
        /// <summary>
        /// The Order&#39;s identifier, unique within the Order&#39;s Account.
        /// </summary>
        /// <value>The Order&#39;s identifier, unique within the Order&#39;s Account.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The time when the Order was created.
        /// </summary>
        /// <value>The time when the Order was created.</value>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public string CreateTime { get; set; }
        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }
        /// <summary>
        /// The ID of the Trade to close when the price threshold is breached.
        /// </summary>
        /// <value>The ID of the Trade to close when the price threshold is breached.</value>
        [DataMember(Name="tradeID", EmitDefaultValue=false)]
        public string TradeID { get; set; }
        /// <summary>
        /// The client ID of the Trade to be closed when the price threshold is breached.
        /// </summary>
        /// <value>The client ID of the Trade to be closed when the price threshold is breached.</value>
        [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
        public string ClientTradeID { get; set; }
        /// <summary>
        /// The price distance specified for the TrailingStopLoss Order.
        /// </summary>
        /// <value>The price distance specified for the TrailingStopLoss Order.</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public string Distance { get; set; }
        /// <summary>
        /// The date/time when the StopLoss Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.
        /// </summary>
        /// <value>The date/time when the StopLoss Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }
        /// <summary>
        /// The trigger price for the Trailing Stop Loss Order. The trailing stop value will trail (follow) the market price by the TSL order&#39;s configured \&quot;distance\&quot; as the market price moves in the winning direction. If the market price moves to a level that is equal to or worse than the trailing stop value, the order will be filled and the Trade will be closed.
        /// </summary>
        /// <value>The trigger price for the Trailing Stop Loss Order. The trailing stop value will trail (follow) the market price by the TSL order&#39;s configured \&quot;distance\&quot; as the market price moves in the winning direction. If the market price moves to a level that is equal to or worse than the trailing stop value, the order will be filled and the Trade will be closed.</value>
        [DataMember(Name="trailingStopValue", EmitDefaultValue=false)]
        public string TrailingStopValue { get; set; }
        /// <summary>
        /// ID of the Transaction that filled this Order (only provided when the Order&#39;s state is FILLED)
        /// </summary>
        /// <value>ID of the Transaction that filled this Order (only provided when the Order&#39;s state is FILLED)</value>
        [DataMember(Name="fillingTransactionID", EmitDefaultValue=false)]
        public string FillingTransactionID { get; set; }
        /// <summary>
        /// Date/time when the Order was filled (only provided when the Order&#39;s state is FILLED)
        /// </summary>
        /// <value>Date/time when the Order was filled (only provided when the Order&#39;s state is FILLED)</value>
        [DataMember(Name="filledTime", EmitDefaultValue=false)]
        public string FilledTime { get; set; }
        /// <summary>
        /// Trade ID of Trade opened when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was opened as a result of the fill)
        /// </summary>
        /// <value>Trade ID of Trade opened when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was opened as a result of the fill)</value>
        [DataMember(Name="tradeOpenedID", EmitDefaultValue=false)]
        public string TradeOpenedID { get; set; }
        /// <summary>
        /// Trade ID of Trade reduced when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was reduced as a result of the fill)
        /// </summary>
        /// <value>Trade ID of Trade reduced when the Order was filled (only provided when the Order&#39;s state is FILLED and a Trade was reduced as a result of the fill)</value>
        [DataMember(Name="tradeReducedID", EmitDefaultValue=false)]
        public string TradeReducedID { get; set; }
        /// <summary>
        /// Trade IDs of Trades closed when the Order was filled (only provided when the Order&#39;s state is FILLED and one or more Trades were closed as a result of the fill)
        /// </summary>
        /// <value>Trade IDs of Trades closed when the Order was filled (only provided when the Order&#39;s state is FILLED and one or more Trades were closed as a result of the fill)</value>
        [DataMember(Name="tradeClosedIDs", EmitDefaultValue=false)]
        public List<string> TradeClosedIDs { get; set; }
        /// <summary>
        /// ID of the Transaction that cancelled the Order (only provided when the Order&#39;s state is CANCELLED)
        /// </summary>
        /// <value>ID of the Transaction that cancelled the Order (only provided when the Order&#39;s state is CANCELLED)</value>
        [DataMember(Name="cancellingTransactionID", EmitDefaultValue=false)]
        public string CancellingTransactionID { get; set; }
        /// <summary>
        /// Date/time when the Order was cancelled (only provided when the state of the Order is CANCELLED)
        /// </summary>
        /// <value>Date/time when the Order was cancelled (only provided when the state of the Order is CANCELLED)</value>
        [DataMember(Name="cancelledTime", EmitDefaultValue=false)]
        public string CancelledTime { get; set; }
        /// <summary>
        /// The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace).
        /// </summary>
        /// <value>The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace).</value>
        [DataMember(Name="replacesOrderID", EmitDefaultValue=false)]
        public string ReplacesOrderID { get; set; }
        /// <summary>
        /// The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace).
        /// </summary>
        /// <value>The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace).</value>
        [DataMember(Name="replacedByOrderID", EmitDefaultValue=false)]
        public string ReplacedByOrderID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrailingStopLossOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
            sb.Append("  TrailingStopValue: ").Append(TrailingStopValue).Append("\n");
            sb.Append("  FillingTransactionID: ").Append(FillingTransactionID).Append("\n");
            sb.Append("  FilledTime: ").Append(FilledTime).Append("\n");
            sb.Append("  TradeOpenedID: ").Append(TradeOpenedID).Append("\n");
            sb.Append("  TradeReducedID: ").Append(TradeReducedID).Append("\n");
            sb.Append("  TradeClosedIDs: ").Append(TradeClosedIDs).Append("\n");
            sb.Append("  CancellingTransactionID: ").Append(CancellingTransactionID).Append("\n");
            sb.Append("  CancelledTime: ").Append(CancelledTime).Append("\n");
            sb.Append("  ReplacesOrderID: ").Append(ReplacesOrderID).Append("\n");
            sb.Append("  ReplacedByOrderID: ").Append(ReplacedByOrderID).Append("\n");
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
            return this.Equals(obj as TrailingStopLossOrder);
        }

        /// <summary>
        /// Returns true if TrailingStopLossOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of TrailingStopLossOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrailingStopLossOrder other)
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
                    this.CreateTime == other.CreateTime ||
                    this.CreateTime != null &&
                    this.CreateTime.Equals(other.CreateTime)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.ClientExtensions == other.ClientExtensions ||
                    this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(other.ClientExtensions)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.TradeID == other.TradeID ||
                    this.TradeID != null &&
                    this.TradeID.Equals(other.TradeID)
                ) && 
                (
                    this.ClientTradeID == other.ClientTradeID ||
                    this.ClientTradeID != null &&
                    this.ClientTradeID.Equals(other.ClientTradeID)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.TimeInForce == other.TimeInForce ||
                    this.TimeInForce != null &&
                    this.TimeInForce.Equals(other.TimeInForce)
                ) && 
                (
                    this.GtdTime == other.GtdTime ||
                    this.GtdTime != null &&
                    this.GtdTime.Equals(other.GtdTime)
                ) && 
                (
                    this.TriggerCondition == other.TriggerCondition ||
                    this.TriggerCondition != null &&
                    this.TriggerCondition.Equals(other.TriggerCondition)
                ) && 
                (
                    this.TrailingStopValue == other.TrailingStopValue ||
                    this.TrailingStopValue != null &&
                    this.TrailingStopValue.Equals(other.TrailingStopValue)
                ) && 
                (
                    this.FillingTransactionID == other.FillingTransactionID ||
                    this.FillingTransactionID != null &&
                    this.FillingTransactionID.Equals(other.FillingTransactionID)
                ) && 
                (
                    this.FilledTime == other.FilledTime ||
                    this.FilledTime != null &&
                    this.FilledTime.Equals(other.FilledTime)
                ) && 
                (
                    this.TradeOpenedID == other.TradeOpenedID ||
                    this.TradeOpenedID != null &&
                    this.TradeOpenedID.Equals(other.TradeOpenedID)
                ) && 
                (
                    this.TradeReducedID == other.TradeReducedID ||
                    this.TradeReducedID != null &&
                    this.TradeReducedID.Equals(other.TradeReducedID)
                ) && 
                (
                    this.TradeClosedIDs == other.TradeClosedIDs ||
                    this.TradeClosedIDs != null &&
                    this.TradeClosedIDs.SequenceEqual(other.TradeClosedIDs)
                ) && 
                (
                    this.CancellingTransactionID == other.CancellingTransactionID ||
                    this.CancellingTransactionID != null &&
                    this.CancellingTransactionID.Equals(other.CancellingTransactionID)
                ) && 
                (
                    this.CancelledTime == other.CancelledTime ||
                    this.CancelledTime != null &&
                    this.CancelledTime.Equals(other.CancelledTime)
                ) && 
                (
                    this.ReplacesOrderID == other.ReplacesOrderID ||
                    this.ReplacesOrderID != null &&
                    this.ReplacesOrderID.Equals(other.ReplacesOrderID)
                ) && 
                (
                    this.ReplacedByOrderID == other.ReplacedByOrderID ||
                    this.ReplacedByOrderID != null &&
                    this.ReplacedByOrderID.Equals(other.ReplacedByOrderID)
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
                if (this.CreateTime != null)
                    hash = hash * 59 + this.CreateTime.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ClientExtensions != null)
                    hash = hash * 59 + this.ClientExtensions.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TradeID != null)
                    hash = hash * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hash = hash * 59 + this.ClientTradeID.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.TimeInForce != null)
                    hash = hash * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hash = hash * 59 + this.GtdTime.GetHashCode();
                if (this.TriggerCondition != null)
                    hash = hash * 59 + this.TriggerCondition.GetHashCode();
                if (this.TrailingStopValue != null)
                    hash = hash * 59 + this.TrailingStopValue.GetHashCode();
                if (this.FillingTransactionID != null)
                    hash = hash * 59 + this.FillingTransactionID.GetHashCode();
                if (this.FilledTime != null)
                    hash = hash * 59 + this.FilledTime.GetHashCode();
                if (this.TradeOpenedID != null)
                    hash = hash * 59 + this.TradeOpenedID.GetHashCode();
                if (this.TradeReducedID != null)
                    hash = hash * 59 + this.TradeReducedID.GetHashCode();
                if (this.TradeClosedIDs != null)
                    hash = hash * 59 + this.TradeClosedIDs.GetHashCode();
                if (this.CancellingTransactionID != null)
                    hash = hash * 59 + this.CancellingTransactionID.GetHashCode();
                if (this.CancelledTime != null)
                    hash = hash * 59 + this.CancelledTime.GetHashCode();
                if (this.ReplacesOrderID != null)
                    hash = hash * 59 + this.ReplacesOrderID.GetHashCode();
                if (this.ReplacedByOrderID != null)
                    hash = hash * 59 + this.ReplacedByOrderID.GetHashCode();
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
