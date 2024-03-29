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
    /// InlineResponse20014
    /// </summary>
    [DataContract]
    public partial class InlineResponse20014 :  IEquatable<InlineResponse20014>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20014" /> class.
        /// </summary>
        /// <param name="LongOrderCreateTransaction">LongOrderCreateTransaction.</param>
        /// <param name="LongOrderFillTransaction">LongOrderFillTransaction.</param>
        /// <param name="LongOrderCancelTransaction">LongOrderCancelTransaction.</param>
        /// <param name="ShortOrderCreateTransaction">ShortOrderCreateTransaction.</param>
        /// <param name="ShortOrderFillTransaction">ShortOrderFillTransaction.</param>
        /// <param name="ShortOrderCancelTransaction">ShortOrderCancelTransaction.</param>
        /// <param name="RelatedTransactionIDs">The IDs of all Transactions that were created while satisfying the request..</param>
        /// <param name="LastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        public InlineResponse20014(MarketOrderTransaction LongOrderCreateTransaction = default(MarketOrderTransaction), OrderFillTransaction LongOrderFillTransaction = default(OrderFillTransaction), OrderCancelTransaction LongOrderCancelTransaction = default(OrderCancelTransaction), MarketOrderTransaction ShortOrderCreateTransaction = default(MarketOrderTransaction), OrderFillTransaction ShortOrderFillTransaction = default(OrderFillTransaction), OrderCancelTransaction ShortOrderCancelTransaction = default(OrderCancelTransaction), List<string> RelatedTransactionIDs = default(List<string>), string LastTransactionID = default(string))
        {
            this.LongOrderCreateTransaction = LongOrderCreateTransaction;
            this.LongOrderFillTransaction = LongOrderFillTransaction;
            this.LongOrderCancelTransaction = LongOrderCancelTransaction;
            this.ShortOrderCreateTransaction = ShortOrderCreateTransaction;
            this.ShortOrderFillTransaction = ShortOrderFillTransaction;
            this.ShortOrderCancelTransaction = ShortOrderCancelTransaction;
            this.RelatedTransactionIDs = RelatedTransactionIDs;
            this.LastTransactionID = LastTransactionID;
        }
        
        /// <summary>
        /// Gets or Sets LongOrderCreateTransaction
        /// </summary>
        [DataMember(Name="longOrderCreateTransaction", EmitDefaultValue=false)]
        public MarketOrderTransaction LongOrderCreateTransaction { get; set; }
        /// <summary>
        /// Gets or Sets LongOrderFillTransaction
        /// </summary>
        [DataMember(Name="longOrderFillTransaction", EmitDefaultValue=false)]
        public OrderFillTransaction LongOrderFillTransaction { get; set; }
        /// <summary>
        /// Gets or Sets LongOrderCancelTransaction
        /// </summary>
        [DataMember(Name="longOrderCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction LongOrderCancelTransaction { get; set; }
        /// <summary>
        /// Gets or Sets ShortOrderCreateTransaction
        /// </summary>
        [DataMember(Name="shortOrderCreateTransaction", EmitDefaultValue=false)]
        public MarketOrderTransaction ShortOrderCreateTransaction { get; set; }
        /// <summary>
        /// Gets or Sets ShortOrderFillTransaction
        /// </summary>
        [DataMember(Name="shortOrderFillTransaction", EmitDefaultValue=false)]
        public OrderFillTransaction ShortOrderFillTransaction { get; set; }
        /// <summary>
        /// Gets or Sets ShortOrderCancelTransaction
        /// </summary>
        [DataMember(Name="shortOrderCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction ShortOrderCancelTransaction { get; set; }
        /// <summary>
        /// The IDs of all Transactions that were created while satisfying the request.
        /// </summary>
        /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
        [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=false)]
        public List<string> RelatedTransactionIDs { get; set; }
        /// <summary>
        /// The ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>The ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public string LastTransactionID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20014 {\n");
            sb.Append("  LongOrderCreateTransaction: ").Append(LongOrderCreateTransaction).Append("\n");
            sb.Append("  LongOrderFillTransaction: ").Append(LongOrderFillTransaction).Append("\n");
            sb.Append("  LongOrderCancelTransaction: ").Append(LongOrderCancelTransaction).Append("\n");
            sb.Append("  ShortOrderCreateTransaction: ").Append(ShortOrderCreateTransaction).Append("\n");
            sb.Append("  ShortOrderFillTransaction: ").Append(ShortOrderFillTransaction).Append("\n");
            sb.Append("  ShortOrderCancelTransaction: ").Append(ShortOrderCancelTransaction).Append("\n");
            sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
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
            return this.Equals(obj as InlineResponse20014);
        }

        /// <summary>
        /// Returns true if InlineResponse20014 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20014 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20014 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LongOrderCreateTransaction == other.LongOrderCreateTransaction ||
                    this.LongOrderCreateTransaction != null &&
                    this.LongOrderCreateTransaction.Equals(other.LongOrderCreateTransaction)
                ) && 
                (
                    this.LongOrderFillTransaction == other.LongOrderFillTransaction ||
                    this.LongOrderFillTransaction != null &&
                    this.LongOrderFillTransaction.Equals(other.LongOrderFillTransaction)
                ) && 
                (
                    this.LongOrderCancelTransaction == other.LongOrderCancelTransaction ||
                    this.LongOrderCancelTransaction != null &&
                    this.LongOrderCancelTransaction.Equals(other.LongOrderCancelTransaction)
                ) && 
                (
                    this.ShortOrderCreateTransaction == other.ShortOrderCreateTransaction ||
                    this.ShortOrderCreateTransaction != null &&
                    this.ShortOrderCreateTransaction.Equals(other.ShortOrderCreateTransaction)
                ) && 
                (
                    this.ShortOrderFillTransaction == other.ShortOrderFillTransaction ||
                    this.ShortOrderFillTransaction != null &&
                    this.ShortOrderFillTransaction.Equals(other.ShortOrderFillTransaction)
                ) && 
                (
                    this.ShortOrderCancelTransaction == other.ShortOrderCancelTransaction ||
                    this.ShortOrderCancelTransaction != null &&
                    this.ShortOrderCancelTransaction.Equals(other.ShortOrderCancelTransaction)
                ) && 
                (
                    this.RelatedTransactionIDs == other.RelatedTransactionIDs ||
                    this.RelatedTransactionIDs != null &&
                    this.RelatedTransactionIDs.SequenceEqual(other.RelatedTransactionIDs)
                ) && 
                (
                    this.LastTransactionID == other.LastTransactionID ||
                    this.LastTransactionID != null &&
                    this.LastTransactionID.Equals(other.LastTransactionID)
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
                if (this.LongOrderCreateTransaction != null)
                    hash = hash * 59 + this.LongOrderCreateTransaction.GetHashCode();
                if (this.LongOrderFillTransaction != null)
                    hash = hash * 59 + this.LongOrderFillTransaction.GetHashCode();
                if (this.LongOrderCancelTransaction != null)
                    hash = hash * 59 + this.LongOrderCancelTransaction.GetHashCode();
                if (this.ShortOrderCreateTransaction != null)
                    hash = hash * 59 + this.ShortOrderCreateTransaction.GetHashCode();
                if (this.ShortOrderFillTransaction != null)
                    hash = hash * 59 + this.ShortOrderFillTransaction.GetHashCode();
                if (this.ShortOrderCancelTransaction != null)
                    hash = hash * 59 + this.ShortOrderCancelTransaction.GetHashCode();
                if (this.RelatedTransactionIDs != null)
                    hash = hash * 59 + this.RelatedTransactionIDs.GetHashCode();
                if (this.LastTransactionID != null)
                    hash = hash * 59 + this.LastTransactionID.GetHashCode();
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
