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
    /// A representation of user information, as available to external (3rd party) clients.
    /// </summary>
    [DataContract]
    public partial class UserInfoExternal :  IEquatable<UserInfoExternal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoExternal" /> class.
        /// </summary>
        /// <param name="UserID">The user&#39;s OANDA-assigned user ID..</param>
        /// <param name="Country">The country that the user is based in..</param>
        /// <param name="FIFO">Flag indicating if the the user&#39;s Accounts adhere to FIFO execution rules..</param>
        public UserInfoExternal(int? UserID = default(int?), string Country = default(string), bool? FIFO = default(bool?))
        {
            this.UserID = UserID;
            this.Country = Country;
            this.FIFO = FIFO;
        }
        
        /// <summary>
        /// The user&#39;s OANDA-assigned user ID.
        /// </summary>
        /// <value>The user&#39;s OANDA-assigned user ID.</value>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int? UserID { get; set; }
        /// <summary>
        /// The country that the user is based in.
        /// </summary>
        /// <value>The country that the user is based in.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Flag indicating if the the user&#39;s Accounts adhere to FIFO execution rules.
        /// </summary>
        /// <value>Flag indicating if the the user&#39;s Accounts adhere to FIFO execution rules.</value>
        [DataMember(Name="FIFO", EmitDefaultValue=false)]
        public bool? FIFO { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfoExternal {\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  FIFO: ").Append(FIFO).Append("\n");
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
            return this.Equals(obj as UserInfoExternal);
        }

        /// <summary>
        /// Returns true if UserInfoExternal instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInfoExternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfoExternal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserID == other.UserID ||
                    this.UserID != null &&
                    this.UserID.Equals(other.UserID)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.FIFO == other.FIFO ||
                    this.FIFO != null &&
                    this.FIFO.Equals(other.FIFO)
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
                if (this.UserID != null)
                    hash = hash * 59 + this.UserID.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.FIFO != null)
                    hash = hash * 59 + this.FIFO.GetHashCode();
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
