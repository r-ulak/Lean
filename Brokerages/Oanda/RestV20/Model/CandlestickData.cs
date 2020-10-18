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
    /// The price data (open, high, low, close) for the Candlestick representation.
    /// </summary>
    [DataContract]
    public partial class CandlestickData :  IEquatable<CandlestickData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CandlestickData" /> class.
        /// </summary>
        /// <param name="O">The first (open) price in the time-range represented by the candlestick..</param>
        /// <param name="H">The highest price in the time-range represented by the candlestick..</param>
        /// <param name="L">The lowest price in the time-range represented by the candlestick..</param>
        /// <param name="C">The last (closing) price in the time-range represented by the candlestick..</param>
        public CandlestickData(string O = default(string), string H = default(string), string L = default(string), string C = default(string))
        {
            this.O = O;
            this.H = H;
            this.L = L;
            this.C = C;
        }
        
        /// <summary>
        /// The first (open) price in the time-range represented by the candlestick.
        /// </summary>
        /// <value>The first (open) price in the time-range represented by the candlestick.</value>
        [DataMember(Name="o", EmitDefaultValue=false)]
        public string O { get; set; }
        /// <summary>
        /// The highest price in the time-range represented by the candlestick.
        /// </summary>
        /// <value>The highest price in the time-range represented by the candlestick.</value>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public string H { get; set; }
        /// <summary>
        /// The lowest price in the time-range represented by the candlestick.
        /// </summary>
        /// <value>The lowest price in the time-range represented by the candlestick.</value>
        [DataMember(Name="l", EmitDefaultValue=false)]
        public string L { get; set; }
        /// <summary>
        /// The last (closing) price in the time-range represented by the candlestick.
        /// </summary>
        /// <value>The last (closing) price in the time-range represented by the candlestick.</value>
        [DataMember(Name="c", EmitDefaultValue=false)]
        public string C { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CandlestickData {\n");
            sb.Append("  O: ").Append(O).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  L: ").Append(L).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
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
            return this.Equals(obj as CandlestickData);
        }

        /// <summary>
        /// Returns true if CandlestickData instances are equal
        /// </summary>
        /// <param name="other">Instance of CandlestickData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CandlestickData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.O == other.O ||
                    this.O != null &&
                    this.O.Equals(other.O)
                ) && 
                (
                    this.H == other.H ||
                    this.H != null &&
                    this.H.Equals(other.H)
                ) && 
                (
                    this.L == other.L ||
                    this.L != null &&
                    this.L.Equals(other.L)
                ) && 
                (
                    this.C == other.C ||
                    this.C != null &&
                    this.C.Equals(other.C)
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
                if (this.O != null)
                    hash = hash * 59 + this.O.GetHashCode();
                if (this.H != null)
                    hash = hash * 59 + this.H.GetHashCode();
                if (this.L != null)
                    hash = hash * 59 + this.L.GetHashCode();
                if (this.C != null)
                    hash = hash * 59 + this.C.GetHashCode();
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
