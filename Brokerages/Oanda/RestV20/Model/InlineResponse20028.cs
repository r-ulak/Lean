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
    /// InlineResponse20028
    /// </summary>
    [DataContract]
    public partial class InlineResponse20028 :  IEquatable<InlineResponse20028>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20028" /> class.
        /// </summary>
        /// <param name="TakeProfitOrderCancelTransaction">TakeProfitOrderCancelTransaction.</param>
        /// <param name="TakeProfitOrderTransaction">TakeProfitOrderTransaction.</param>
        /// <param name="TakeProfitOrderFillTransaction">TakeProfitOrderFillTransaction.</param>
        /// <param name="TakeProfitOrderCreatedCancelTransaction">TakeProfitOrderCreatedCancelTransaction.</param>
        /// <param name="StopLossOrderCancelTransaction">StopLossOrderCancelTransaction.</param>
        /// <param name="StopLossOrderTransaction">StopLossOrderTransaction.</param>
        /// <param name="StopLossOrderFillTransaction">StopLossOrderFillTransaction.</param>
        /// <param name="StopLossOrderCreatedCancelTransaction">StopLossOrderCreatedCancelTransaction.</param>
        /// <param name="TrailingStopLossOrderCancelTransaction">TrailingStopLossOrderCancelTransaction.</param>
        /// <param name="TrailingStopLossOrderTransaction">TrailingStopLossOrderTransaction.</param>
        /// <param name="RelatedTransactionIDs">The IDs of all Transactions that were created while satisfying the request..</param>
        /// <param name="LastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        public InlineResponse20028(OrderCancelTransaction TakeProfitOrderCancelTransaction = default(OrderCancelTransaction), TakeProfitOrderTransaction TakeProfitOrderTransaction = default(TakeProfitOrderTransaction), OrderFillTransaction TakeProfitOrderFillTransaction = default(OrderFillTransaction), OrderCancelTransaction TakeProfitOrderCreatedCancelTransaction = default(OrderCancelTransaction), OrderCancelTransaction StopLossOrderCancelTransaction = default(OrderCancelTransaction), StopLossOrderTransaction StopLossOrderTransaction = default(StopLossOrderTransaction), OrderFillTransaction StopLossOrderFillTransaction = default(OrderFillTransaction), OrderCancelTransaction StopLossOrderCreatedCancelTransaction = default(OrderCancelTransaction), OrderCancelTransaction TrailingStopLossOrderCancelTransaction = default(OrderCancelTransaction), TrailingStopLossOrderTransaction TrailingStopLossOrderTransaction = default(TrailingStopLossOrderTransaction), List<string> RelatedTransactionIDs = default(List<string>), string LastTransactionID = default(string))
        {
            this.TakeProfitOrderCancelTransaction = TakeProfitOrderCancelTransaction;
            this.TakeProfitOrderTransaction = TakeProfitOrderTransaction;
            this.TakeProfitOrderFillTransaction = TakeProfitOrderFillTransaction;
            this.TakeProfitOrderCreatedCancelTransaction = TakeProfitOrderCreatedCancelTransaction;
            this.StopLossOrderCancelTransaction = StopLossOrderCancelTransaction;
            this.StopLossOrderTransaction = StopLossOrderTransaction;
            this.StopLossOrderFillTransaction = StopLossOrderFillTransaction;
            this.StopLossOrderCreatedCancelTransaction = StopLossOrderCreatedCancelTransaction;
            this.TrailingStopLossOrderCancelTransaction = TrailingStopLossOrderCancelTransaction;
            this.TrailingStopLossOrderTransaction = TrailingStopLossOrderTransaction;
            this.RelatedTransactionIDs = RelatedTransactionIDs;
            this.LastTransactionID = LastTransactionID;
        }
        
        /// <summary>
        /// Gets or Sets TakeProfitOrderCancelTransaction
        /// </summary>
        [DataMember(Name="takeProfitOrderCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction TakeProfitOrderCancelTransaction { get; set; }
        /// <summary>
        /// Gets or Sets TakeProfitOrderTransaction
        /// </summary>
        [DataMember(Name="takeProfitOrderTransaction", EmitDefaultValue=false)]
        public TakeProfitOrderTransaction TakeProfitOrderTransaction { get; set; }
        /// <summary>
        /// Gets or Sets TakeProfitOrderFillTransaction
        /// </summary>
        [DataMember(Name="takeProfitOrderFillTransaction", EmitDefaultValue=false)]
        public OrderFillTransaction TakeProfitOrderFillTransaction { get; set; }
        /// <summary>
        /// Gets or Sets TakeProfitOrderCreatedCancelTransaction
        /// </summary>
        [DataMember(Name="takeProfitOrderCreatedCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction TakeProfitOrderCreatedCancelTransaction { get; set; }
        /// <summary>
        /// Gets or Sets StopLossOrderCancelTransaction
        /// </summary>
        [DataMember(Name="stopLossOrderCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction StopLossOrderCancelTransaction { get; set; }
        /// <summary>
        /// Gets or Sets StopLossOrderTransaction
        /// </summary>
        [DataMember(Name="stopLossOrderTransaction", EmitDefaultValue=false)]
        public StopLossOrderTransaction StopLossOrderTransaction { get; set; }
        /// <summary>
        /// Gets or Sets StopLossOrderFillTransaction
        /// </summary>
        [DataMember(Name="stopLossOrderFillTransaction", EmitDefaultValue=false)]
        public OrderFillTransaction StopLossOrderFillTransaction { get; set; }
        /// <summary>
        /// Gets or Sets StopLossOrderCreatedCancelTransaction
        /// </summary>
        [DataMember(Name="stopLossOrderCreatedCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction StopLossOrderCreatedCancelTransaction { get; set; }
        /// <summary>
        /// Gets or Sets TrailingStopLossOrderCancelTransaction
        /// </summary>
        [DataMember(Name="trailingStopLossOrderCancelTransaction", EmitDefaultValue=false)]
        public OrderCancelTransaction TrailingStopLossOrderCancelTransaction { get; set; }
        /// <summary>
        /// Gets or Sets TrailingStopLossOrderTransaction
        /// </summary>
        [DataMember(Name="trailingStopLossOrderTransaction", EmitDefaultValue=false)]
        public TrailingStopLossOrderTransaction TrailingStopLossOrderTransaction { get; set; }
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
            sb.Append("class InlineResponse20028 {\n");
            sb.Append("  TakeProfitOrderCancelTransaction: ").Append(TakeProfitOrderCancelTransaction).Append("\n");
            sb.Append("  TakeProfitOrderTransaction: ").Append(TakeProfitOrderTransaction).Append("\n");
            sb.Append("  TakeProfitOrderFillTransaction: ").Append(TakeProfitOrderFillTransaction).Append("\n");
            sb.Append("  TakeProfitOrderCreatedCancelTransaction: ").Append(TakeProfitOrderCreatedCancelTransaction).Append("\n");
            sb.Append("  StopLossOrderCancelTransaction: ").Append(StopLossOrderCancelTransaction).Append("\n");
            sb.Append("  StopLossOrderTransaction: ").Append(StopLossOrderTransaction).Append("\n");
            sb.Append("  StopLossOrderFillTransaction: ").Append(StopLossOrderFillTransaction).Append("\n");
            sb.Append("  StopLossOrderCreatedCancelTransaction: ").Append(StopLossOrderCreatedCancelTransaction).Append("\n");
            sb.Append("  TrailingStopLossOrderCancelTransaction: ").Append(TrailingStopLossOrderCancelTransaction).Append("\n");
            sb.Append("  TrailingStopLossOrderTransaction: ").Append(TrailingStopLossOrderTransaction).Append("\n");
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
            return this.Equals(obj as InlineResponse20028);
        }

        /// <summary>
        /// Returns true if InlineResponse20028 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20028 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20028 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TakeProfitOrderCancelTransaction == other.TakeProfitOrderCancelTransaction ||
                    this.TakeProfitOrderCancelTransaction != null &&
                    this.TakeProfitOrderCancelTransaction.Equals(other.TakeProfitOrderCancelTransaction)
                ) && 
                (
                    this.TakeProfitOrderTransaction == other.TakeProfitOrderTransaction ||
                    this.TakeProfitOrderTransaction != null &&
                    this.TakeProfitOrderTransaction.Equals(other.TakeProfitOrderTransaction)
                ) && 
                (
                    this.TakeProfitOrderFillTransaction == other.TakeProfitOrderFillTransaction ||
                    this.TakeProfitOrderFillTransaction != null &&
                    this.TakeProfitOrderFillTransaction.Equals(other.TakeProfitOrderFillTransaction)
                ) && 
                (
                    this.TakeProfitOrderCreatedCancelTransaction == other.TakeProfitOrderCreatedCancelTransaction ||
                    this.TakeProfitOrderCreatedCancelTransaction != null &&
                    this.TakeProfitOrderCreatedCancelTransaction.Equals(other.TakeProfitOrderCreatedCancelTransaction)
                ) && 
                (
                    this.StopLossOrderCancelTransaction == other.StopLossOrderCancelTransaction ||
                    this.StopLossOrderCancelTransaction != null &&
                    this.StopLossOrderCancelTransaction.Equals(other.StopLossOrderCancelTransaction)
                ) && 
                (
                    this.StopLossOrderTransaction == other.StopLossOrderTransaction ||
                    this.StopLossOrderTransaction != null &&
                    this.StopLossOrderTransaction.Equals(other.StopLossOrderTransaction)
                ) && 
                (
                    this.StopLossOrderFillTransaction == other.StopLossOrderFillTransaction ||
                    this.StopLossOrderFillTransaction != null &&
                    this.StopLossOrderFillTransaction.Equals(other.StopLossOrderFillTransaction)
                ) && 
                (
                    this.StopLossOrderCreatedCancelTransaction == other.StopLossOrderCreatedCancelTransaction ||
                    this.StopLossOrderCreatedCancelTransaction != null &&
                    this.StopLossOrderCreatedCancelTransaction.Equals(other.StopLossOrderCreatedCancelTransaction)
                ) && 
                (
                    this.TrailingStopLossOrderCancelTransaction == other.TrailingStopLossOrderCancelTransaction ||
                    this.TrailingStopLossOrderCancelTransaction != null &&
                    this.TrailingStopLossOrderCancelTransaction.Equals(other.TrailingStopLossOrderCancelTransaction)
                ) && 
                (
                    this.TrailingStopLossOrderTransaction == other.TrailingStopLossOrderTransaction ||
                    this.TrailingStopLossOrderTransaction != null &&
                    this.TrailingStopLossOrderTransaction.Equals(other.TrailingStopLossOrderTransaction)
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
                if (this.TakeProfitOrderCancelTransaction != null)
                    hash = hash * 59 + this.TakeProfitOrderCancelTransaction.GetHashCode();
                if (this.TakeProfitOrderTransaction != null)
                    hash = hash * 59 + this.TakeProfitOrderTransaction.GetHashCode();
                if (this.TakeProfitOrderFillTransaction != null)
                    hash = hash * 59 + this.TakeProfitOrderFillTransaction.GetHashCode();
                if (this.TakeProfitOrderCreatedCancelTransaction != null)
                    hash = hash * 59 + this.TakeProfitOrderCreatedCancelTransaction.GetHashCode();
                if (this.StopLossOrderCancelTransaction != null)
                    hash = hash * 59 + this.StopLossOrderCancelTransaction.GetHashCode();
                if (this.StopLossOrderTransaction != null)
                    hash = hash * 59 + this.StopLossOrderTransaction.GetHashCode();
                if (this.StopLossOrderFillTransaction != null)
                    hash = hash * 59 + this.StopLossOrderFillTransaction.GetHashCode();
                if (this.StopLossOrderCreatedCancelTransaction != null)
                    hash = hash * 59 + this.StopLossOrderCreatedCancelTransaction.GetHashCode();
                if (this.TrailingStopLossOrderCancelTransaction != null)
                    hash = hash * 59 + this.TrailingStopLossOrderCancelTransaction.GetHashCode();
                if (this.TrailingStopLossOrderTransaction != null)
                    hash = hash * 59 + this.TrailingStopLossOrderTransaction.GetHashCode();
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
