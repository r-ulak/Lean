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
    /// A StopOrderRequest specifies the parameters that may be set when creating a Stop Order.
    /// </summary>
    [DataContract]
    public partial class StopOrderRequest :  IEquatable<StopOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of the Order to Create. Must be set to \"STOP\" when creating a Stop Order.
        /// </summary>
        /// <value>The type of the Order to Create. Must be set to \"STOP\" when creating a Stop Order.</value>
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
        /// The time-in-force requested for the Stop Order.
        /// </summary>
        /// <value>The time-in-force requested for the Stop Order.</value>
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
        /// Specification of how Positions in the Account are modified when the Order is filled.
        /// </summary>
        /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionFillEnum
        {
            
            /// <summary>
            /// Enum OPENONLY for "OPEN_ONLY"
            /// </summary>
            [EnumMember(Value = "OPEN_ONLY")]
            OPENONLY,
            
            /// <summary>
            /// Enum REDUCEFIRST for "REDUCE_FIRST"
            /// </summary>
            [EnumMember(Value = "REDUCE_FIRST")]
            REDUCEFIRST,
            
            /// <summary>
            /// Enum REDUCEONLY for "REDUCE_ONLY"
            /// </summary>
            [EnumMember(Value = "REDUCE_ONLY")]
            REDUCEONLY,
            
            /// <summary>
            /// Enum DEFAULT for "DEFAULT"
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT,
            
            /// <summary>
            /// Enum POSITIONDEFAULT for "POSITION_DEFAULT"
            /// </summary>
            [EnumMember(Value = "POSITION_DEFAULT")]
            POSITIONDEFAULT
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
        /// The type of the Order to Create. Must be set to \"STOP\" when creating a Stop Order.
        /// </summary>
        /// <value>The type of the Order to Create. Must be set to \"STOP\" when creating a Stop Order.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The time-in-force requested for the Stop Order.
        /// </summary>
        /// <value>The time-in-force requested for the Stop Order.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order is filled.
        /// </summary>
        /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
        [DataMember(Name="positionFill", EmitDefaultValue=false)]
        public PositionFillEnum? PositionFill { get; set; }
        /// <summary>
        /// Specification of what component of a price should be used for comparison when determining if the Order should be filled.
        /// </summary>
        /// <value>Specification of what component of a price should be used for comparison when determining if the Order should be filled.</value>
        [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
        public TriggerConditionEnum? TriggerCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopOrderRequest" /> class.
        /// </summary>
        /// <param name="Type">The type of the Order to Create. Must be set to \&quot;STOP\&quot; when creating a Stop Order..</param>
        /// <param name="Instrument">The Stop Order&#39;s Instrument..</param>
        /// <param name="Units">The quantity requested to be filled by the Stop Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order..</param>
        /// <param name="Price">The price threshold specified for the Stop Order. The Stop Order will only be filled by a market price that is equal to or worse than this price..</param>
        /// <param name="PriceBound">The worst market price that may be used to fill this Stop Order. If the market gaps and crosses through both the price and the priceBound, the Stop Order will be cancelled instead of being filled..</param>
        /// <param name="TimeInForce">The time-in-force requested for the Stop Order..</param>
        /// <param name="GtdTime">The date/time when the Stop Order will be cancelled if its timeInForce is \&quot;GTD\&quot;..</param>
        /// <param name="PositionFill">Specification of how Positions in the Account are modified when the Order is filled..</param>
        /// <param name="TriggerCondition">Specification of what component of a price should be used for comparison when determining if the Order should be filled..</param>
        /// <param name="ClientExtensions">ClientExtensions.</param>
        /// <param name="TakeProfitOnFill">TakeProfitOnFill.</param>
        /// <param name="StopLossOnFill">StopLossOnFill.</param>
        /// <param name="TrailingStopLossOnFill">TrailingStopLossOnFill.</param>
        /// <param name="TradeClientExtensions">TradeClientExtensions.</param>
        public StopOrderRequest(TypeEnum? Type = default(TypeEnum?), string Instrument = default(string), string Units = default(string), string Price = default(string), string PriceBound = default(string), TimeInForceEnum? TimeInForce = default(TimeInForceEnum?), string GtdTime = default(string), PositionFillEnum? PositionFill = default(PositionFillEnum?), TriggerConditionEnum? TriggerCondition = default(TriggerConditionEnum?), ClientExtensions ClientExtensions = default(ClientExtensions), TakeProfitDetails TakeProfitOnFill = default(TakeProfitDetails), StopLossDetails StopLossOnFill = default(StopLossDetails), TrailingStopLossDetails TrailingStopLossOnFill = default(TrailingStopLossDetails), ClientExtensions TradeClientExtensions = default(ClientExtensions))
        {
            this.Type = Type;
            this.Instrument = Instrument;
            this.Units = Units;
            this.Price = Price;
            this.PriceBound = PriceBound;
            this.TimeInForce = TimeInForce;
            this.GtdTime = GtdTime;
            this.PositionFill = PositionFill;
            this.TriggerCondition = TriggerCondition;
            this.ClientExtensions = ClientExtensions;
            this.TakeProfitOnFill = TakeProfitOnFill;
            this.StopLossOnFill = StopLossOnFill;
            this.TrailingStopLossOnFill = TrailingStopLossOnFill;
            this.TradeClientExtensions = TradeClientExtensions;
        }
        
        /// <summary>
        /// The Stop Order&#39;s Instrument.
        /// </summary>
        /// <value>The Stop Order&#39;s Instrument.</value>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public string Instrument { get; set; }
        /// <summary>
        /// The quantity requested to be filled by the Stop Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
        /// </summary>
        /// <value>The quantity requested to be filled by the Stop Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }
        /// <summary>
        /// The price threshold specified for the Stop Order. The Stop Order will only be filled by a market price that is equal to or worse than this price.
        /// </summary>
        /// <value>The price threshold specified for the Stop Order. The Stop Order will only be filled by a market price that is equal to or worse than this price.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }
        /// <summary>
        /// The worst market price that may be used to fill this Stop Order. If the market gaps and crosses through both the price and the priceBound, the Stop Order will be cancelled instead of being filled.
        /// </summary>
        /// <value>The worst market price that may be used to fill this Stop Order. If the market gaps and crosses through both the price and the priceBound, the Stop Order will be cancelled instead of being filled.</value>
        [DataMember(Name="priceBound", EmitDefaultValue=false)]
        public string PriceBound { get; set; }
        /// <summary>
        /// The date/time when the Stop Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.
        /// </summary>
        /// <value>The date/time when the Stop Order will be cancelled if its timeInForce is \&quot;GTD\&quot;.</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }
        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }
        /// <summary>
        /// Gets or Sets TakeProfitOnFill
        /// </summary>
        [DataMember(Name="takeProfitOnFill", EmitDefaultValue=false)]
        public TakeProfitDetails TakeProfitOnFill { get; set; }
        /// <summary>
        /// Gets or Sets StopLossOnFill
        /// </summary>
        [DataMember(Name="stopLossOnFill", EmitDefaultValue=false)]
        public StopLossDetails StopLossOnFill { get; set; }
        /// <summary>
        /// Gets or Sets TrailingStopLossOnFill
        /// </summary>
        [DataMember(Name="trailingStopLossOnFill", EmitDefaultValue=false)]
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }
        /// <summary>
        /// Gets or Sets TradeClientExtensions
        /// </summary>
        [DataMember(Name="tradeClientExtensions", EmitDefaultValue=false)]
        public ClientExtensions TradeClientExtensions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopOrderRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceBound: ").Append(PriceBound).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
            sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
            sb.Append("  TakeProfitOnFill: ").Append(TakeProfitOnFill).Append("\n");
            sb.Append("  StopLossOnFill: ").Append(StopLossOnFill).Append("\n");
            sb.Append("  TrailingStopLossOnFill: ").Append(TrailingStopLossOnFill).Append("\n");
            sb.Append("  TradeClientExtensions: ").Append(TradeClientExtensions).Append("\n");
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
            return this.Equals(obj as StopOrderRequest);
        }

        /// <summary>
        /// Returns true if StopOrderRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of StopOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopOrderRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    this.PriceBound == other.PriceBound ||
                    this.PriceBound != null &&
                    this.PriceBound.Equals(other.PriceBound)
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
                    this.PositionFill == other.PositionFill ||
                    this.PositionFill != null &&
                    this.PositionFill.Equals(other.PositionFill)
                ) && 
                (
                    this.TriggerCondition == other.TriggerCondition ||
                    this.TriggerCondition != null &&
                    this.TriggerCondition.Equals(other.TriggerCondition)
                ) && 
                (
                    this.ClientExtensions == other.ClientExtensions ||
                    this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(other.ClientExtensions)
                ) && 
                (
                    this.TakeProfitOnFill == other.TakeProfitOnFill ||
                    this.TakeProfitOnFill != null &&
                    this.TakeProfitOnFill.Equals(other.TakeProfitOnFill)
                ) && 
                (
                    this.StopLossOnFill == other.StopLossOnFill ||
                    this.StopLossOnFill != null &&
                    this.StopLossOnFill.Equals(other.StopLossOnFill)
                ) && 
                (
                    this.TrailingStopLossOnFill == other.TrailingStopLossOnFill ||
                    this.TrailingStopLossOnFill != null &&
                    this.TrailingStopLossOnFill.Equals(other.TrailingStopLossOnFill)
                ) && 
                (
                    this.TradeClientExtensions == other.TradeClientExtensions ||
                    this.TradeClientExtensions != null &&
                    this.TradeClientExtensions.Equals(other.TradeClientExtensions)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Instrument != null)
                    hash = hash * 59 + this.Instrument.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.PriceBound != null)
                    hash = hash * 59 + this.PriceBound.GetHashCode();
                if (this.TimeInForce != null)
                    hash = hash * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hash = hash * 59 + this.GtdTime.GetHashCode();
                if (this.PositionFill != null)
                    hash = hash * 59 + this.PositionFill.GetHashCode();
                if (this.TriggerCondition != null)
                    hash = hash * 59 + this.TriggerCondition.GetHashCode();
                if (this.ClientExtensions != null)
                    hash = hash * 59 + this.ClientExtensions.GetHashCode();
                if (this.TakeProfitOnFill != null)
                    hash = hash * 59 + this.TakeProfitOnFill.GetHashCode();
                if (this.StopLossOnFill != null)
                    hash = hash * 59 + this.StopLossOnFill.GetHashCode();
                if (this.TrailingStopLossOnFill != null)
                    hash = hash * 59 + this.TrailingStopLossOnFill.GetHashCode();
                if (this.TradeClientExtensions != null)
                    hash = hash * 59 + this.TradeClientExtensions.GetHashCode();
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
