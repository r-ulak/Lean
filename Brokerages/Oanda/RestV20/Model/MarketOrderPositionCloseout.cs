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
    /// A MarketOrderPositionCloseout specifies the extensions to a Market Order when it has been created to closeout a specific Position.
    /// </summary>
    [DataContract]
    public partial class MarketOrderPositionCloseout :  IEquatable<MarketOrderPositionCloseout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketOrderPositionCloseout" /> class.
        /// </summary>
        /// <param name="Instrument">The instrument of the Position being closed out..</param>
        /// <param name="Units">Indication of how much of the Position to close. Either \&quot;ALL\&quot;, or a DecimalNumber reflection a partial close of the Trade. The DecimalNumber must always be positive, and represent a number that doesn&#39;t exceed the absolute size of the Position..</param>
        public MarketOrderPositionCloseout(string Instrument = default(string), string Units = default(string))
        {
            this.Instrument = Instrument;
            this.Units = Units;
        }
        
        /// <summary>
        /// The instrument of the Position being closed out.
        /// </summary>
        /// <value>The instrument of the Position being closed out.</value>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public string Instrument { get; set; }
        /// <summary>
        /// Indication of how much of the Position to close. Either \&quot;ALL\&quot;, or a DecimalNumber reflection a partial close of the Trade. The DecimalNumber must always be positive, and represent a number that doesn&#39;t exceed the absolute size of the Position.
        /// </summary>
        /// <value>Indication of how much of the Position to close. Either \&quot;ALL\&quot;, or a DecimalNumber reflection a partial close of the Trade. The DecimalNumber must always be positive, and represent a number that doesn&#39;t exceed the absolute size of the Position.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketOrderPositionCloseout {\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(obj as MarketOrderPositionCloseout);
        }

        /// <summary>
        /// Returns true if MarketOrderPositionCloseout instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketOrderPositionCloseout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketOrderPositionCloseout other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Instrument == other.Instrument ||
                    this.Instrument != null &&
                    this.Instrument.Equals(other.Instrument)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.Equals(other.Units)
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
                if (this.Instrument != null)
                    hash = hash * 59 + this.Instrument.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
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
