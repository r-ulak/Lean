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
    /// The base Order definition specifies the properties that are common to all Orders.
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
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
        /// The current state of the Order.
        /// </summary>
        /// <value>The current state of the Order.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Id">The Order&#39;s identifier, unique within the Order&#39;s Account..</param>
        /// <param name="CreateTime">The time when the Order was created..</param>
        /// <param name="State">The current state of the Order..</param>
        /// <param name="ClientExtensions">ClientExtensions.</param>
        public Order(string Id = default(string), string CreateTime = default(string), StateEnum? State = default(StateEnum?), ClientExtensions ClientExtensions = default(ClientExtensions))
        {
            this.Id = Id;
            this.CreateTime = CreateTime;
            this.State = State;
            this.ClientExtensions = ClientExtensions;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
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
