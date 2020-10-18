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
    /// A TradeReduce object represents a Trade for an instrument that was reduced (either partially or fully) in an Account. It is found embedded in Transactions that affect the position of an instrument in the account, specifically the OrderFill Transaction.
    /// </summary>
    [DataContract]
    public partial class TradeReduce :  IEquatable<TradeReduce>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeReduce" /> class.
        /// </summary>
        /// <param name="TradeID">The ID of the Trade that was reduced or closed.</param>
        /// <param name="Units">The number of units that the Trade was reduced by.</param>
        /// <param name="RealizedPL">The PL realized when reducing the Trade.</param>
        /// <param name="Financing">The financing paid/collected when reducing the Trade.</param>
        public TradeReduce(string TradeID = default(string), string Units = default(string), string RealizedPL = default(string), string Financing = default(string))
        {
            this.TradeID = TradeID;
            this.Units = Units;
            this.RealizedPL = RealizedPL;
            this.Financing = Financing;
        }
        
        /// <summary>
        /// The ID of the Trade that was reduced or closed
        /// </summary>
        /// <value>The ID of the Trade that was reduced or closed</value>
        [DataMember(Name="tradeID", EmitDefaultValue=false)]
        public string TradeID { get; set; }
        /// <summary>
        /// The number of units that the Trade was reduced by
        /// </summary>
        /// <value>The number of units that the Trade was reduced by</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }
        /// <summary>
        /// The PL realized when reducing the Trade
        /// </summary>
        /// <value>The PL realized when reducing the Trade</value>
        [DataMember(Name="realizedPL", EmitDefaultValue=false)]
        public string RealizedPL { get; set; }
        /// <summary>
        /// The financing paid/collected when reducing the Trade
        /// </summary>
        /// <value>The financing paid/collected when reducing the Trade</value>
        [DataMember(Name="financing", EmitDefaultValue=false)]
        public string Financing { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeReduce {\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  RealizedPL: ").Append(RealizedPL).Append("\n");
            sb.Append("  Financing: ").Append(Financing).Append("\n");
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
            return this.Equals(obj as TradeReduce);
        }

        /// <summary>
        /// Returns true if TradeReduce instances are equal
        /// </summary>
        /// <param name="other">Instance of TradeReduce to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeReduce other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TradeID == other.TradeID ||
                    this.TradeID != null &&
                    this.TradeID.Equals(other.TradeID)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.Equals(other.Units)
                ) && 
                (
                    this.RealizedPL == other.RealizedPL ||
                    this.RealizedPL != null &&
                    this.RealizedPL.Equals(other.RealizedPL)
                ) && 
                (
                    this.Financing == other.Financing ||
                    this.Financing != null &&
                    this.Financing.Equals(other.Financing)
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
                if (this.TradeID != null)
                    hash = hash * 59 + this.TradeID.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.RealizedPL != null)
                    hash = hash * 59 + this.RealizedPL.GetHashCode();
                if (this.Financing != null)
                    hash = hash * 59 + this.Financing.GetHashCode();
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
