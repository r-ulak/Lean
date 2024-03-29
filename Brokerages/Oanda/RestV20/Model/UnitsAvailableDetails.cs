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
    /// Representation of many units of an Instrument are available to be traded for both long and short Orders.
    /// </summary>
    [DataContract]
    public partial class UnitsAvailableDetails :  IEquatable<UnitsAvailableDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitsAvailableDetails" /> class.
        /// </summary>
        /// <param name="_Long">The units available for long Orders..</param>
        /// <param name="_Short">The units available for short Orders..</param>
        public UnitsAvailableDetails(string _Long = default(string), string _Short = default(string))
        {
            this._Long = _Long;
            this._Short = _Short;
        }
        
        /// <summary>
        /// The units available for long Orders.
        /// </summary>
        /// <value>The units available for long Orders.</value>
        [DataMember(Name="long", EmitDefaultValue=false)]
        public string _Long { get; set; }
        /// <summary>
        /// The units available for short Orders.
        /// </summary>
        /// <value>The units available for short Orders.</value>
        [DataMember(Name="short", EmitDefaultValue=false)]
        public string _Short { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnitsAvailableDetails {\n");
            sb.Append("  _Long: ").Append(_Long).Append("\n");
            sb.Append("  _Short: ").Append(_Short).Append("\n");
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
            return this.Equals(obj as UnitsAvailableDetails);
        }

        /// <summary>
        /// Returns true if UnitsAvailableDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of UnitsAvailableDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnitsAvailableDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Long == other._Long ||
                    this._Long != null &&
                    this._Long.Equals(other._Long)
                ) && 
                (
                    this._Short == other._Short ||
                    this._Short != null &&
                    this._Short.Equals(other._Short)
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
                if (this._Long != null)
                    hash = hash * 59 + this._Long.GetHashCode();
                if (this._Short != null)
                    hash = hash * 59 + this._Short.GetHashCode();
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
