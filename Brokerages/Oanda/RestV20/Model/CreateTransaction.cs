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
    /// A CreateTransaction represents the creation of an Account.
    /// </summary>
    [DataContract]
    public partial class CreateTransaction :  IEquatable<CreateTransaction>, IValidatableObject
    {
        /// <summary>
        /// The Type of the Transaction. Always set to \"CREATE\" in a CreateTransaction.
        /// </summary>
        /// <value>The Type of the Transaction. Always set to \"CREATE\" in a CreateTransaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
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
        /// The Type of the Transaction. Always set to \"CREATE\" in a CreateTransaction.
        /// </summary>
        /// <value>The Type of the Transaction. Always set to \"CREATE\" in a CreateTransaction.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransaction" /> class.
        /// </summary>
        /// <param name="Id">The Transaction&#39;s Identifier..</param>
        /// <param name="Time">The date/time when the Transaction was created..</param>
        /// <param name="UserID">The ID of the user that initiated the creation of the Transaction..</param>
        /// <param name="AccountID">The ID of the Account the Transaction was created for..</param>
        /// <param name="BatchID">The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously..</param>
        /// <param name="RequestID">The Request ID of the request which generated the transaction..</param>
        /// <param name="Type">The Type of the Transaction. Always set to \&quot;CREATE\&quot; in a CreateTransaction..</param>
        /// <param name="DivisionID">The ID of the Division that the Account is in.</param>
        /// <param name="SiteID">The ID of the Site that the Account was created at.</param>
        /// <param name="AccountUserID">The ID of the user that the Account was created for.</param>
        /// <param name="AccountNumber">The number of the Account within the site/division/user.</param>
        /// <param name="HomeCurrency">The home currency of the Account.</param>
        public CreateTransaction(string Id = default(string), string Time = default(string), int? UserID = default(int?), string AccountID = default(string), string BatchID = default(string), string RequestID = default(string), TypeEnum? Type = default(TypeEnum?), int? DivisionID = default(int?), int? SiteID = default(int?), int? AccountUserID = default(int?), int? AccountNumber = default(int?), string HomeCurrency = default(string))
        {
            this.Id = Id;
            this.Time = Time;
            this.UserID = UserID;
            this.AccountID = AccountID;
            this.BatchID = BatchID;
            this.RequestID = RequestID;
            this.Type = Type;
            this.DivisionID = DivisionID;
            this.SiteID = SiteID;
            this.AccountUserID = AccountUserID;
            this.AccountNumber = AccountNumber;
            this.HomeCurrency = HomeCurrency;
        }
        
        /// <summary>
        /// The Transaction&#39;s Identifier.
        /// </summary>
        /// <value>The Transaction&#39;s Identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The date/time when the Transaction was created.
        /// </summary>
        /// <value>The date/time when the Transaction was created.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }
        /// <summary>
        /// The ID of the user that initiated the creation of the Transaction.
        /// </summary>
        /// <value>The ID of the user that initiated the creation of the Transaction.</value>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int? UserID { get; set; }
        /// <summary>
        /// The ID of the Account the Transaction was created for.
        /// </summary>
        /// <value>The ID of the Account the Transaction was created for.</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public string AccountID { get; set; }
        /// <summary>
        /// The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.
        /// </summary>
        /// <value>The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.</value>
        [DataMember(Name="batchID", EmitDefaultValue=false)]
        public string BatchID { get; set; }
        /// <summary>
        /// The Request ID of the request which generated the transaction.
        /// </summary>
        /// <value>The Request ID of the request which generated the transaction.</value>
        [DataMember(Name="requestID", EmitDefaultValue=false)]
        public string RequestID { get; set; }
        /// <summary>
        /// The ID of the Division that the Account is in
        /// </summary>
        /// <value>The ID of the Division that the Account is in</value>
        [DataMember(Name="divisionID", EmitDefaultValue=false)]
        public int? DivisionID { get; set; }
        /// <summary>
        /// The ID of the Site that the Account was created at
        /// </summary>
        /// <value>The ID of the Site that the Account was created at</value>
        [DataMember(Name="siteID", EmitDefaultValue=false)]
        public int? SiteID { get; set; }
        /// <summary>
        /// The ID of the user that the Account was created for
        /// </summary>
        /// <value>The ID of the user that the Account was created for</value>
        [DataMember(Name="accountUserID", EmitDefaultValue=false)]
        public int? AccountUserID { get; set; }
        /// <summary>
        /// The number of the Account within the site/division/user
        /// </summary>
        /// <value>The number of the Account within the site/division/user</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public int? AccountNumber { get; set; }
        /// <summary>
        /// The home currency of the Account
        /// </summary>
        /// <value>The home currency of the Account</value>
        [DataMember(Name="homeCurrency", EmitDefaultValue=false)]
        public string HomeCurrency { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  BatchID: ").Append(BatchID).Append("\n");
            sb.Append("  RequestID: ").Append(RequestID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DivisionID: ").Append(DivisionID).Append("\n");
            sb.Append("  SiteID: ").Append(SiteID).Append("\n");
            sb.Append("  AccountUserID: ").Append(AccountUserID).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  HomeCurrency: ").Append(HomeCurrency).Append("\n");
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
            return this.Equals(obj as CreateTransaction);
        }

        /// <summary>
        /// Returns true if CreateTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransaction other)
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
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.UserID == other.UserID ||
                    this.UserID != null &&
                    this.UserID.Equals(other.UserID)
                ) && 
                (
                    this.AccountID == other.AccountID ||
                    this.AccountID != null &&
                    this.AccountID.Equals(other.AccountID)
                ) && 
                (
                    this.BatchID == other.BatchID ||
                    this.BatchID != null &&
                    this.BatchID.Equals(other.BatchID)
                ) && 
                (
                    this.RequestID == other.RequestID ||
                    this.RequestID != null &&
                    this.RequestID.Equals(other.RequestID)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.DivisionID == other.DivisionID ||
                    this.DivisionID != null &&
                    this.DivisionID.Equals(other.DivisionID)
                ) && 
                (
                    this.SiteID == other.SiteID ||
                    this.SiteID != null &&
                    this.SiteID.Equals(other.SiteID)
                ) && 
                (
                    this.AccountUserID == other.AccountUserID ||
                    this.AccountUserID != null &&
                    this.AccountUserID.Equals(other.AccountUserID)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.HomeCurrency == other.HomeCurrency ||
                    this.HomeCurrency != null &&
                    this.HomeCurrency.Equals(other.HomeCurrency)
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
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.UserID != null)
                    hash = hash * 59 + this.UserID.GetHashCode();
                if (this.AccountID != null)
                    hash = hash * 59 + this.AccountID.GetHashCode();
                if (this.BatchID != null)
                    hash = hash * 59 + this.BatchID.GetHashCode();
                if (this.RequestID != null)
                    hash = hash * 59 + this.RequestID.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.DivisionID != null)
                    hash = hash * 59 + this.DivisionID.GetHashCode();
                if (this.SiteID != null)
                    hash = hash * 59 + this.SiteID.GetHashCode();
                if (this.AccountUserID != null)
                    hash = hash * 59 + this.AccountUserID.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.HomeCurrency != null)
                    hash = hash * 59 + this.HomeCurrency.GetHashCode();
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
