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
    /// InlineResponse20017
    /// </summary>
    [DataContract]
    public partial class InlineResponse20017 :  IEquatable<InlineResponse20017>, IValidatableObject
    {

        /// <summary>
        /// A filter that can be used when fetching Transactions
        /// </summary>
        /// <value>A filter that can be used when fetching Transactions</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum ORDER for "ORDER"
            /// </summary>
            [EnumMember(Value = "ORDER")]
            ORDER,
            
            /// <summary>
            /// Enum FUNDING for "FUNDING"
            /// </summary>
            [EnumMember(Value = "FUNDING")]
            FUNDING,
            
            /// <summary>
            /// Enum ADMIN for "ADMIN"
            /// </summary>
            [EnumMember(Value = "ADMIN")]
            ADMIN,
            
            /// <summary>
            /// Enum CREATE for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            CREATE,
            
            /// <summary>
            /// Enum CLOSE for "CLOSE"
            /// </summary>
            [EnumMember(Value = "CLOSE")]
            CLOSE,
            
            /// <summary>
            /// Enum REOPEN for "REOPEN"
            /// </summary>
            [EnumMember(Value = "REOPEN")]
            REOPEN,
            
            /// <summary>
            /// Enum CLIENTCONFIGURE for "CLIENT_CONFIGURE"
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE")]
            CLIENTCONFIGURE,
            
            /// <summary>
            /// Enum CLIENTCONFIGUREREJECT for "CLIENT_CONFIGURE_REJECT"
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE_REJECT")]
            CLIENTCONFIGUREREJECT,
            
            /// <summary>
            /// Enum TRANSFERFUNDS for "TRANSFER_FUNDS"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS")]
            TRANSFERFUNDS,
            
            /// <summary>
            /// Enum TRANSFERFUNDSREJECT for "TRANSFER_FUNDS_REJECT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS_REJECT")]
            TRANSFERFUNDSREJECT,
            
            /// <summary>
            /// Enum MARKETORDER for "MARKET_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER")]
            MARKETORDER,
            
            /// <summary>
            /// Enum MARKETORDERREJECT for "MARKET_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_REJECT")]
            MARKETORDERREJECT,
            
            /// <summary>
            /// Enum LIMITORDER for "LIMIT_ORDER"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER")]
            LIMITORDER,
            
            /// <summary>
            /// Enum LIMITORDERREJECT for "LIMIT_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER_REJECT")]
            LIMITORDERREJECT,
            
            /// <summary>
            /// Enum STOPORDER for "STOP_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER")]
            STOPORDER,
            
            /// <summary>
            /// Enum STOPORDERREJECT for "STOP_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER_REJECT")]
            STOPORDERREJECT,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDER for "MARKET_IF_TOUCHED_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
            MARKETIFTOUCHEDORDER,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDERREJECT for "MARKET_IF_TOUCHED_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER_REJECT")]
            MARKETIFTOUCHEDORDERREJECT,
            
            /// <summary>
            /// Enum TAKEPROFITORDER for "TAKE_PROFIT_ORDER"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER")]
            TAKEPROFITORDER,
            
            /// <summary>
            /// Enum TAKEPROFITORDERREJECT for "TAKE_PROFIT_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER_REJECT")]
            TAKEPROFITORDERREJECT,
            
            /// <summary>
            /// Enum STOPLOSSORDER for "STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER")]
            STOPLOSSORDER,
            
            /// <summary>
            /// Enum STOPLOSSORDERREJECT for "STOP_LOSS_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER_REJECT")]
            STOPLOSSORDERREJECT,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDER for "TRAILING_STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
            TRAILINGSTOPLOSSORDER,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDERREJECT for "TRAILING_STOP_LOSS_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER_REJECT")]
            TRAILINGSTOPLOSSORDERREJECT,
            
            /// <summary>
            /// Enum ONECANCELSALLORDER for "ONE_CANCELS_ALL_ORDER"
            /// </summary>
            [EnumMember(Value = "ONE_CANCELS_ALL_ORDER")]
            ONECANCELSALLORDER,
            
            /// <summary>
            /// Enum ONECANCELSALLORDERREJECT for "ONE_CANCELS_ALL_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "ONE_CANCELS_ALL_ORDER_REJECT")]
            ONECANCELSALLORDERREJECT,
            
            /// <summary>
            /// Enum ONECANCELSALLORDERTRIGGERED for "ONE_CANCELS_ALL_ORDER_TRIGGERED"
            /// </summary>
            [EnumMember(Value = "ONE_CANCELS_ALL_ORDER_TRIGGERED")]
            ONECANCELSALLORDERTRIGGERED,
            
            /// <summary>
            /// Enum ORDERFILL for "ORDER_FILL"
            /// </summary>
            [EnumMember(Value = "ORDER_FILL")]
            ORDERFILL,
            
            /// <summary>
            /// Enum ORDERCANCEL for "ORDER_CANCEL"
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL")]
            ORDERCANCEL,
            
            /// <summary>
            /// Enum ORDERCANCELREJECT for "ORDER_CANCEL_REJECT"
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL_REJECT")]
            ORDERCANCELREJECT,
            
            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFY for "ORDER_CLIENT_EXTENSIONS_MODIFY"
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY")]
            ORDERCLIENTEXTENSIONSMODIFY,
            
            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFYREJECT for "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT"
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            ORDERCLIENTEXTENSIONSMODIFYREJECT,
            
            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFY for "TRADE_CLIENT_EXTENSIONS_MODIFY"
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY")]
            TRADECLIENTEXTENSIONSMODIFY,
            
            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFYREJECT for "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT"
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            TRADECLIENTEXTENSIONSMODIFYREJECT,
            
            /// <summary>
            /// Enum MARGINCALLENTER for "MARGIN_CALL_ENTER"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_ENTER")]
            MARGINCALLENTER,
            
            /// <summary>
            /// Enum MARGINCALLEXTEND for "MARGIN_CALL_EXTEND"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXTEND")]
            MARGINCALLEXTEND,
            
            /// <summary>
            /// Enum MARGINCALLEXIT for "MARGIN_CALL_EXIT"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXIT")]
            MARGINCALLEXIT,
            
            /// <summary>
            /// Enum DELAYEDTRADECLOSURE for "DELAYED_TRADE_CLOSURE"
            /// </summary>
            [EnumMember(Value = "DELAYED_TRADE_CLOSURE")]
            DELAYEDTRADECLOSURE,
            
            /// <summary>
            /// Enum DAILYFINANCING for "DAILY_FINANCING"
            /// </summary>
            [EnumMember(Value = "DAILY_FINANCING")]
            DAILYFINANCING,
            
            /// <summary>
            /// Enum RESETRESETTABLEPL for "RESET_RESETTABLE_PL"
            /// </summary>
            [EnumMember(Value = "RESET_RESETTABLE_PL")]
            RESETRESETTABLEPL
        }

        /// <summary>
        /// The Transaction-type filter provided in the request
        /// </summary>
        /// <value>The Transaction-type filter provided in the request</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public List<TypeEnum> Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20017" /> class.
        /// </summary>
        /// <param name="From">The starting time provided in the request..</param>
        /// <param name="To">The ending time provided in the request..</param>
        /// <param name="PageSize">The pageSize provided in the request.</param>
        /// <param name="Type">The Transaction-type filter provided in the request.</param>
        /// <param name="Count">The number of Transactions that are contained in the pages returned.</param>
        /// <param name="Pages">The list of URLs that represent idrange queries providing the data for each page in the query results.</param>
        /// <param name="LastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        public InlineResponse20017(string From = default(string), string To = default(string), int? PageSize = default(int?), List<TypeEnum> Type = default(List<TypeEnum>), int? Count = default(int?), List<string> Pages = default(List<string>), string LastTransactionID = default(string))
        {
            this.From = From;
            this.To = To;
            this.PageSize = PageSize;
            this.Type = Type;
            this.Count = Count;
            this.Pages = Pages;
            this.LastTransactionID = LastTransactionID;
        }
        
        /// <summary>
        /// The starting time provided in the request.
        /// </summary>
        /// <value>The starting time provided in the request.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }
        /// <summary>
        /// The ending time provided in the request.
        /// </summary>
        /// <value>The ending time provided in the request.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }
        /// <summary>
        /// The pageSize provided in the request
        /// </summary>
        /// <value>The pageSize provided in the request</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// The number of Transactions that are contained in the pages returned
        /// </summary>
        /// <value>The number of Transactions that are contained in the pages returned</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// The list of URLs that represent idrange queries providing the data for each page in the query results
        /// </summary>
        /// <value>The list of URLs that represent idrange queries providing the data for each page in the query results</value>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public List<string> Pages { get; set; }
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
            sb.Append("class InlineResponse20017 {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
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
            return this.Equals(obj as InlineResponse20017);
        }

        /// <summary>
        /// Returns true if InlineResponse20017 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20017 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20017 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.SequenceEqual(other.Type)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.SequenceEqual(other.Pages)
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
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Pages != null)
                    hash = hash * 59 + this.Pages.GetHashCode();
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
