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
    /// The full details of a client&#39;s Account. This includes full open Trade, open Position and pending Order representation.
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="Id">The Account&#39;s identifier.</param>
        /// <param name="Alias">Client-assigned alias for the Account. Only provided if the Account has an alias set.</param>
        /// <param name="Currency">The home currency of the Account.</param>
        /// <param name="Balance">The current balance of the Account. Represented in the Account&#39;s home currency..</param>
        /// <param name="CreatedByUserID">ID of the user that created the Account..</param>
        /// <param name="CreatedTime">The date/time when the Account was created..</param>
        /// <param name="Pl">The total profit/loss realized over the lifetime of the Account. Represented in the Account&#39;s home currency..</param>
        /// <param name="ResettablePL">The total realized profit/loss for the Account since it was last reset by the client. Represented in the Account&#39;s home currency..</param>
        /// <param name="ResettabledPLTime">The date/time that the Account&#39;s resettablePL was last reset..</param>
        /// <param name="MarginRate">Client-provided margin rate override for the Account. The effective margin rate of the Account is the lesser of this value and the OANDA margin rate for the Account&#39;s division. This value is only provided if a margin rate override exists for the Account..</param>
        /// <param name="MarginCallEnterTime">The date/time when the Account entered a margin call state. Only provided if the Account is in a margin call..</param>
        /// <param name="MarginCallExtensionCount">The number of times that the Account&#39;s current margin call was extended..</param>
        /// <param name="LastMarginCallExtensionTime">The date/time of the Account&#39;s last margin call extension..</param>
        /// <param name="OpenTradeCount">The number of Trades currently open in the Account..</param>
        /// <param name="OpenPositionCount">The number of Positions currently open in the Account..</param>
        /// <param name="PendingOrderCount">The number of Orders currently pending in the Account..</param>
        /// <param name="HedgingEnabled">Flag indicating that the Account has hedging enabled..</param>
        /// <param name="UnrealizedPL">The total unrealized profit/loss for all Trades currently open in the Account. Represented in the Account&#39;s home currency..</param>
        /// <param name="NAV">The net asset value of the Account. Equal to Account balance + unrealizedPL. Represented in the Account&#39;s home currency..</param>
        /// <param name="MarginUsed">Margin currently used for the Account. Represented in the Account&#39;s home currency..</param>
        /// <param name="MarginAvailable">Margin available for Account. Represented in the Account&#39;s home currency..</param>
        /// <param name="PositionValue">The value of the Account&#39;s open positions represented in the Account&#39;s home currency..</param>
        /// <param name="MarginCloseoutUnrealizedPL">The Account&#39;s margin closeout unrealized PL..</param>
        /// <param name="MarginCloseoutNAV">The Account&#39;s margin closeout NAV..</param>
        /// <param name="MarginCloseoutMarginUsed">The Account&#39;s margin closeout margin used..</param>
        /// <param name="MarginCloseoutPercent">The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation..</param>
        /// <param name="MarginCloseoutPositionValue">The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency..</param>
        /// <param name="WithdrawalLimit">The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account..</param>
        /// <param name="MarginCallMarginUsed">The Account&#39;s margin call margin used..</param>
        /// <param name="MarginCallPercent">The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation..</param>
        /// <param name="LastTransactionID">The ID of the last Transaction created for the Account..</param>
        /// <param name="Trades">The details of the Trades currently open in the Account..</param>
        /// <param name="Positions">The details all Account Positions..</param>
        /// <param name="Orders">The details of the Orders currently pending in the Account..</param>
        public Account(string Id = default(string), string Alias = default(string), string Currency = default(string), string Balance = default(string), int? CreatedByUserID = default(int?), string CreatedTime = default(string), string Pl = default(string), string ResettablePL = default(string), string ResettabledPLTime = default(string), string MarginRate = default(string), string MarginCallEnterTime = default(string), int? MarginCallExtensionCount = default(int?), string LastMarginCallExtensionTime = default(string), int? OpenTradeCount = default(int?), int? OpenPositionCount = default(int?), int? PendingOrderCount = default(int?), bool? HedgingEnabled = default(bool?), string UnrealizedPL = default(string), string NAV = default(string), string MarginUsed = default(string), string MarginAvailable = default(string), string PositionValue = default(string), string MarginCloseoutUnrealizedPL = default(string), string MarginCloseoutNAV = default(string), string MarginCloseoutMarginUsed = default(string), string MarginCloseoutPercent = default(string), string MarginCloseoutPositionValue = default(string), string WithdrawalLimit = default(string), string MarginCallMarginUsed = default(string), string MarginCallPercent = default(string), string LastTransactionID = default(string), List<TradeSummary> Trades = default(List<TradeSummary>), List<Position> Positions = default(List<Position>), List<Order> Orders = default(List<Order>))
        {
            this.Id = Id;
            this.Alias = Alias;
            this.Currency = Currency;
            this.Balance = Balance;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedTime = CreatedTime;
            this.Pl = Pl;
            this.ResettablePL = ResettablePL;
            this.ResettabledPLTime = ResettabledPLTime;
            this.MarginRate = MarginRate;
            this.MarginCallEnterTime = MarginCallEnterTime;
            this.MarginCallExtensionCount = MarginCallExtensionCount;
            this.LastMarginCallExtensionTime = LastMarginCallExtensionTime;
            this.OpenTradeCount = OpenTradeCount;
            this.OpenPositionCount = OpenPositionCount;
            this.PendingOrderCount = PendingOrderCount;
            this.HedgingEnabled = HedgingEnabled;
            this.UnrealizedPL = UnrealizedPL;
            this.NAV = NAV;
            this.MarginUsed = MarginUsed;
            this.MarginAvailable = MarginAvailable;
            this.PositionValue = PositionValue;
            this.MarginCloseoutUnrealizedPL = MarginCloseoutUnrealizedPL;
            this.MarginCloseoutNAV = MarginCloseoutNAV;
            this.MarginCloseoutMarginUsed = MarginCloseoutMarginUsed;
            this.MarginCloseoutPercent = MarginCloseoutPercent;
            this.MarginCloseoutPositionValue = MarginCloseoutPositionValue;
            this.WithdrawalLimit = WithdrawalLimit;
            this.MarginCallMarginUsed = MarginCallMarginUsed;
            this.MarginCallPercent = MarginCallPercent;
            this.LastTransactionID = LastTransactionID;
            this.Trades = Trades;
            this.Positions = Positions;
            this.Orders = Orders;
        }
        
        /// <summary>
        /// The Account&#39;s identifier
        /// </summary>
        /// <value>The Account&#39;s identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Client-assigned alias for the Account. Only provided if the Account has an alias set
        /// </summary>
        /// <value>Client-assigned alias for the Account. Only provided if the Account has an alias set</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }
        /// <summary>
        /// The home currency of the Account
        /// </summary>
        /// <value>The home currency of the Account</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// The current balance of the Account. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The current balance of the Account. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }
        /// <summary>
        /// ID of the user that created the Account.
        /// </summary>
        /// <value>ID of the user that created the Account.</value>
        [DataMember(Name="createdByUserID", EmitDefaultValue=false)]
        public int? CreatedByUserID { get; set; }
        /// <summary>
        /// The date/time when the Account was created.
        /// </summary>
        /// <value>The date/time when the Account was created.</value>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public string CreatedTime { get; set; }
        /// <summary>
        /// The total profit/loss realized over the lifetime of the Account. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The total profit/loss realized over the lifetime of the Account. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="pl", EmitDefaultValue=false)]
        public string Pl { get; set; }
        /// <summary>
        /// The total realized profit/loss for the Account since it was last reset by the client. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The total realized profit/loss for the Account since it was last reset by the client. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="resettablePL", EmitDefaultValue=false)]
        public string ResettablePL { get; set; }
        /// <summary>
        /// The date/time that the Account&#39;s resettablePL was last reset.
        /// </summary>
        /// <value>The date/time that the Account&#39;s resettablePL was last reset.</value>
        [DataMember(Name="resettabledPLTime", EmitDefaultValue=false)]
        public string ResettabledPLTime { get; set; }
        /// <summary>
        /// Client-provided margin rate override for the Account. The effective margin rate of the Account is the lesser of this value and the OANDA margin rate for the Account&#39;s division. This value is only provided if a margin rate override exists for the Account.
        /// </summary>
        /// <value>Client-provided margin rate override for the Account. The effective margin rate of the Account is the lesser of this value and the OANDA margin rate for the Account&#39;s division. This value is only provided if a margin rate override exists for the Account.</value>
        [DataMember(Name="marginRate", EmitDefaultValue=false)]
        public string MarginRate { get; set; }
        /// <summary>
        /// The date/time when the Account entered a margin call state. Only provided if the Account is in a margin call.
        /// </summary>
        /// <value>The date/time when the Account entered a margin call state. Only provided if the Account is in a margin call.</value>
        [DataMember(Name="marginCallEnterTime", EmitDefaultValue=false)]
        public string MarginCallEnterTime { get; set; }
        /// <summary>
        /// The number of times that the Account&#39;s current margin call was extended.
        /// </summary>
        /// <value>The number of times that the Account&#39;s current margin call was extended.</value>
        [DataMember(Name="marginCallExtensionCount", EmitDefaultValue=false)]
        public int? MarginCallExtensionCount { get; set; }
        /// <summary>
        /// The date/time of the Account&#39;s last margin call extension.
        /// </summary>
        /// <value>The date/time of the Account&#39;s last margin call extension.</value>
        [DataMember(Name="lastMarginCallExtensionTime", EmitDefaultValue=false)]
        public string LastMarginCallExtensionTime { get; set; }
        /// <summary>
        /// The number of Trades currently open in the Account.
        /// </summary>
        /// <value>The number of Trades currently open in the Account.</value>
        [DataMember(Name="openTradeCount", EmitDefaultValue=false)]
        public int? OpenTradeCount { get; set; }
        /// <summary>
        /// The number of Positions currently open in the Account.
        /// </summary>
        /// <value>The number of Positions currently open in the Account.</value>
        [DataMember(Name="openPositionCount", EmitDefaultValue=false)]
        public int? OpenPositionCount { get; set; }
        /// <summary>
        /// The number of Orders currently pending in the Account.
        /// </summary>
        /// <value>The number of Orders currently pending in the Account.</value>
        [DataMember(Name="pendingOrderCount", EmitDefaultValue=false)]
        public int? PendingOrderCount { get; set; }
        /// <summary>
        /// Flag indicating that the Account has hedging enabled.
        /// </summary>
        /// <value>Flag indicating that the Account has hedging enabled.</value>
        [DataMember(Name="hedgingEnabled", EmitDefaultValue=false)]
        public bool? HedgingEnabled { get; set; }
        /// <summary>
        /// The total unrealized profit/loss for all Trades currently open in the Account. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The total unrealized profit/loss for all Trades currently open in the Account. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
        public string UnrealizedPL { get; set; }
        /// <summary>
        /// The net asset value of the Account. Equal to Account balance + unrealizedPL. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The net asset value of the Account. Equal to Account balance + unrealizedPL. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="NAV", EmitDefaultValue=false)]
        public string NAV { get; set; }
        /// <summary>
        /// Margin currently used for the Account. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>Margin currently used for the Account. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="marginUsed", EmitDefaultValue=false)]
        public string MarginUsed { get; set; }
        /// <summary>
        /// Margin available for Account. Represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>Margin available for Account. Represented in the Account&#39;s home currency.</value>
        [DataMember(Name="marginAvailable", EmitDefaultValue=false)]
        public string MarginAvailable { get; set; }
        /// <summary>
        /// The value of the Account&#39;s open positions represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The value of the Account&#39;s open positions represented in the Account&#39;s home currency.</value>
        [DataMember(Name="positionValue", EmitDefaultValue=false)]
        public string PositionValue { get; set; }
        /// <summary>
        /// The Account&#39;s margin closeout unrealized PL.
        /// </summary>
        /// <value>The Account&#39;s margin closeout unrealized PL.</value>
        [DataMember(Name="marginCloseoutUnrealizedPL", EmitDefaultValue=false)]
        public string MarginCloseoutUnrealizedPL { get; set; }
        /// <summary>
        /// The Account&#39;s margin closeout NAV.
        /// </summary>
        /// <value>The Account&#39;s margin closeout NAV.</value>
        [DataMember(Name="marginCloseoutNAV", EmitDefaultValue=false)]
        public string MarginCloseoutNAV { get; set; }
        /// <summary>
        /// The Account&#39;s margin closeout margin used.
        /// </summary>
        /// <value>The Account&#39;s margin closeout margin used.</value>
        [DataMember(Name="marginCloseoutMarginUsed", EmitDefaultValue=false)]
        public string MarginCloseoutMarginUsed { get; set; }
        /// <summary>
        /// The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation.
        /// </summary>
        /// <value>The Account&#39;s margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation.</value>
        [DataMember(Name="marginCloseoutPercent", EmitDefaultValue=false)]
        public string MarginCloseoutPercent { get; set; }
        /// <summary>
        /// The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency.
        /// </summary>
        /// <value>The value of the Account&#39;s open positions as used for margin closeout calculations represented in the Account&#39;s home currency.</value>
        [DataMember(Name="marginCloseoutPositionValue", EmitDefaultValue=false)]
        public string MarginCloseoutPositionValue { get; set; }
        /// <summary>
        /// The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account.
        /// </summary>
        /// <value>The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account.</value>
        [DataMember(Name="withdrawalLimit", EmitDefaultValue=false)]
        public string WithdrawalLimit { get; set; }
        /// <summary>
        /// The Account&#39;s margin call margin used.
        /// </summary>
        /// <value>The Account&#39;s margin call margin used.</value>
        [DataMember(Name="marginCallMarginUsed", EmitDefaultValue=false)]
        public string MarginCallMarginUsed { get; set; }
        /// <summary>
        /// The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation.
        /// </summary>
        /// <value>The Account&#39;s margin call percentage. When this value is 1.0 or above the Account is in a margin call situation.</value>
        [DataMember(Name="marginCallPercent", EmitDefaultValue=false)]
        public string MarginCallPercent { get; set; }
        /// <summary>
        /// The ID of the last Transaction created for the Account.
        /// </summary>
        /// <value>The ID of the last Transaction created for the Account.</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public string LastTransactionID { get; set; }
        /// <summary>
        /// The details of the Trades currently open in the Account.
        /// </summary>
        /// <value>The details of the Trades currently open in the Account.</value>
        [DataMember(Name="trades", EmitDefaultValue=false)]
        public List<TradeSummary> Trades { get; set; }
        /// <summary>
        /// The details all Account Positions.
        /// </summary>
        /// <value>The details all Account Positions.</value>
        [DataMember(Name="positions", EmitDefaultValue=false)]
        public List<Position> Positions { get; set; }
        /// <summary>
        /// The details of the Orders currently pending in the Account.
        /// </summary>
        /// <value>The details of the Orders currently pending in the Account.</value>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<Order> Orders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CreatedByUserID: ").Append(CreatedByUserID).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Pl: ").Append(Pl).Append("\n");
            sb.Append("  ResettablePL: ").Append(ResettablePL).Append("\n");
            sb.Append("  ResettabledPLTime: ").Append(ResettabledPLTime).Append("\n");
            sb.Append("  MarginRate: ").Append(MarginRate).Append("\n");
            sb.Append("  MarginCallEnterTime: ").Append(MarginCallEnterTime).Append("\n");
            sb.Append("  MarginCallExtensionCount: ").Append(MarginCallExtensionCount).Append("\n");
            sb.Append("  LastMarginCallExtensionTime: ").Append(LastMarginCallExtensionTime).Append("\n");
            sb.Append("  OpenTradeCount: ").Append(OpenTradeCount).Append("\n");
            sb.Append("  OpenPositionCount: ").Append(OpenPositionCount).Append("\n");
            sb.Append("  PendingOrderCount: ").Append(PendingOrderCount).Append("\n");
            sb.Append("  HedgingEnabled: ").Append(HedgingEnabled).Append("\n");
            sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
            sb.Append("  NAV: ").Append(NAV).Append("\n");
            sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
            sb.Append("  MarginAvailable: ").Append(MarginAvailable).Append("\n");
            sb.Append("  PositionValue: ").Append(PositionValue).Append("\n");
            sb.Append("  MarginCloseoutUnrealizedPL: ").Append(MarginCloseoutUnrealizedPL).Append("\n");
            sb.Append("  MarginCloseoutNAV: ").Append(MarginCloseoutNAV).Append("\n");
            sb.Append("  MarginCloseoutMarginUsed: ").Append(MarginCloseoutMarginUsed).Append("\n");
            sb.Append("  MarginCloseoutPercent: ").Append(MarginCloseoutPercent).Append("\n");
            sb.Append("  MarginCloseoutPositionValue: ").Append(MarginCloseoutPositionValue).Append("\n");
            sb.Append("  WithdrawalLimit: ").Append(WithdrawalLimit).Append("\n");
            sb.Append("  MarginCallMarginUsed: ").Append(MarginCallMarginUsed).Append("\n");
            sb.Append("  MarginCallPercent: ").Append(MarginCallPercent).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
            sb.Append("  Trades: ").Append(Trades).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
            return this.Equals(obj as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="other">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account other)
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
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) && 
                (
                    this.CreatedByUserID == other.CreatedByUserID ||
                    this.CreatedByUserID != null &&
                    this.CreatedByUserID.Equals(other.CreatedByUserID)
                ) && 
                (
                    this.CreatedTime == other.CreatedTime ||
                    this.CreatedTime != null &&
                    this.CreatedTime.Equals(other.CreatedTime)
                ) && 
                (
                    this.Pl == other.Pl ||
                    this.Pl != null &&
                    this.Pl.Equals(other.Pl)
                ) && 
                (
                    this.ResettablePL == other.ResettablePL ||
                    this.ResettablePL != null &&
                    this.ResettablePL.Equals(other.ResettablePL)
                ) && 
                (
                    this.ResettabledPLTime == other.ResettabledPLTime ||
                    this.ResettabledPLTime != null &&
                    this.ResettabledPLTime.Equals(other.ResettabledPLTime)
                ) && 
                (
                    this.MarginRate == other.MarginRate ||
                    this.MarginRate != null &&
                    this.MarginRate.Equals(other.MarginRate)
                ) && 
                (
                    this.MarginCallEnterTime == other.MarginCallEnterTime ||
                    this.MarginCallEnterTime != null &&
                    this.MarginCallEnterTime.Equals(other.MarginCallEnterTime)
                ) && 
                (
                    this.MarginCallExtensionCount == other.MarginCallExtensionCount ||
                    this.MarginCallExtensionCount != null &&
                    this.MarginCallExtensionCount.Equals(other.MarginCallExtensionCount)
                ) && 
                (
                    this.LastMarginCallExtensionTime == other.LastMarginCallExtensionTime ||
                    this.LastMarginCallExtensionTime != null &&
                    this.LastMarginCallExtensionTime.Equals(other.LastMarginCallExtensionTime)
                ) && 
                (
                    this.OpenTradeCount == other.OpenTradeCount ||
                    this.OpenTradeCount != null &&
                    this.OpenTradeCount.Equals(other.OpenTradeCount)
                ) && 
                (
                    this.OpenPositionCount == other.OpenPositionCount ||
                    this.OpenPositionCount != null &&
                    this.OpenPositionCount.Equals(other.OpenPositionCount)
                ) && 
                (
                    this.PendingOrderCount == other.PendingOrderCount ||
                    this.PendingOrderCount != null &&
                    this.PendingOrderCount.Equals(other.PendingOrderCount)
                ) && 
                (
                    this.HedgingEnabled == other.HedgingEnabled ||
                    this.HedgingEnabled != null &&
                    this.HedgingEnabled.Equals(other.HedgingEnabled)
                ) && 
                (
                    this.UnrealizedPL == other.UnrealizedPL ||
                    this.UnrealizedPL != null &&
                    this.UnrealizedPL.Equals(other.UnrealizedPL)
                ) && 
                (
                    this.NAV == other.NAV ||
                    this.NAV != null &&
                    this.NAV.Equals(other.NAV)
                ) && 
                (
                    this.MarginUsed == other.MarginUsed ||
                    this.MarginUsed != null &&
                    this.MarginUsed.Equals(other.MarginUsed)
                ) && 
                (
                    this.MarginAvailable == other.MarginAvailable ||
                    this.MarginAvailable != null &&
                    this.MarginAvailable.Equals(other.MarginAvailable)
                ) && 
                (
                    this.PositionValue == other.PositionValue ||
                    this.PositionValue != null &&
                    this.PositionValue.Equals(other.PositionValue)
                ) && 
                (
                    this.MarginCloseoutUnrealizedPL == other.MarginCloseoutUnrealizedPL ||
                    this.MarginCloseoutUnrealizedPL != null &&
                    this.MarginCloseoutUnrealizedPL.Equals(other.MarginCloseoutUnrealizedPL)
                ) && 
                (
                    this.MarginCloseoutNAV == other.MarginCloseoutNAV ||
                    this.MarginCloseoutNAV != null &&
                    this.MarginCloseoutNAV.Equals(other.MarginCloseoutNAV)
                ) && 
                (
                    this.MarginCloseoutMarginUsed == other.MarginCloseoutMarginUsed ||
                    this.MarginCloseoutMarginUsed != null &&
                    this.MarginCloseoutMarginUsed.Equals(other.MarginCloseoutMarginUsed)
                ) && 
                (
                    this.MarginCloseoutPercent == other.MarginCloseoutPercent ||
                    this.MarginCloseoutPercent != null &&
                    this.MarginCloseoutPercent.Equals(other.MarginCloseoutPercent)
                ) && 
                (
                    this.MarginCloseoutPositionValue == other.MarginCloseoutPositionValue ||
                    this.MarginCloseoutPositionValue != null &&
                    this.MarginCloseoutPositionValue.Equals(other.MarginCloseoutPositionValue)
                ) && 
                (
                    this.WithdrawalLimit == other.WithdrawalLimit ||
                    this.WithdrawalLimit != null &&
                    this.WithdrawalLimit.Equals(other.WithdrawalLimit)
                ) && 
                (
                    this.MarginCallMarginUsed == other.MarginCallMarginUsed ||
                    this.MarginCallMarginUsed != null &&
                    this.MarginCallMarginUsed.Equals(other.MarginCallMarginUsed)
                ) && 
                (
                    this.MarginCallPercent == other.MarginCallPercent ||
                    this.MarginCallPercent != null &&
                    this.MarginCallPercent.Equals(other.MarginCallPercent)
                ) && 
                (
                    this.LastTransactionID == other.LastTransactionID ||
                    this.LastTransactionID != null &&
                    this.LastTransactionID.Equals(other.LastTransactionID)
                ) && 
                (
                    this.Trades == other.Trades ||
                    this.Trades != null &&
                    this.Trades.SequenceEqual(other.Trades)
                ) && 
                (
                    this.Positions == other.Positions ||
                    this.Positions != null &&
                    this.Positions.SequenceEqual(other.Positions)
                ) && 
                (
                    this.Orders == other.Orders ||
                    this.Orders != null &&
                    this.Orders.SequenceEqual(other.Orders)
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
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.CreatedByUserID != null)
                    hash = hash * 59 + this.CreatedByUserID.GetHashCode();
                if (this.CreatedTime != null)
                    hash = hash * 59 + this.CreatedTime.GetHashCode();
                if (this.Pl != null)
                    hash = hash * 59 + this.Pl.GetHashCode();
                if (this.ResettablePL != null)
                    hash = hash * 59 + this.ResettablePL.GetHashCode();
                if (this.ResettabledPLTime != null)
                    hash = hash * 59 + this.ResettabledPLTime.GetHashCode();
                if (this.MarginRate != null)
                    hash = hash * 59 + this.MarginRate.GetHashCode();
                if (this.MarginCallEnterTime != null)
                    hash = hash * 59 + this.MarginCallEnterTime.GetHashCode();
                if (this.MarginCallExtensionCount != null)
                    hash = hash * 59 + this.MarginCallExtensionCount.GetHashCode();
                if (this.LastMarginCallExtensionTime != null)
                    hash = hash * 59 + this.LastMarginCallExtensionTime.GetHashCode();
                if (this.OpenTradeCount != null)
                    hash = hash * 59 + this.OpenTradeCount.GetHashCode();
                if (this.OpenPositionCount != null)
                    hash = hash * 59 + this.OpenPositionCount.GetHashCode();
                if (this.PendingOrderCount != null)
                    hash = hash * 59 + this.PendingOrderCount.GetHashCode();
                if (this.HedgingEnabled != null)
                    hash = hash * 59 + this.HedgingEnabled.GetHashCode();
                if (this.UnrealizedPL != null)
                    hash = hash * 59 + this.UnrealizedPL.GetHashCode();
                if (this.NAV != null)
                    hash = hash * 59 + this.NAV.GetHashCode();
                if (this.MarginUsed != null)
                    hash = hash * 59 + this.MarginUsed.GetHashCode();
                if (this.MarginAvailable != null)
                    hash = hash * 59 + this.MarginAvailable.GetHashCode();
                if (this.PositionValue != null)
                    hash = hash * 59 + this.PositionValue.GetHashCode();
                if (this.MarginCloseoutUnrealizedPL != null)
                    hash = hash * 59 + this.MarginCloseoutUnrealizedPL.GetHashCode();
                if (this.MarginCloseoutNAV != null)
                    hash = hash * 59 + this.MarginCloseoutNAV.GetHashCode();
                if (this.MarginCloseoutMarginUsed != null)
                    hash = hash * 59 + this.MarginCloseoutMarginUsed.GetHashCode();
                if (this.MarginCloseoutPercent != null)
                    hash = hash * 59 + this.MarginCloseoutPercent.GetHashCode();
                if (this.MarginCloseoutPositionValue != null)
                    hash = hash * 59 + this.MarginCloseoutPositionValue.GetHashCode();
                if (this.WithdrawalLimit != null)
                    hash = hash * 59 + this.WithdrawalLimit.GetHashCode();
                if (this.MarginCallMarginUsed != null)
                    hash = hash * 59 + this.MarginCallMarginUsed.GetHashCode();
                if (this.MarginCallPercent != null)
                    hash = hash * 59 + this.MarginCallPercent.GetHashCode();
                if (this.LastTransactionID != null)
                    hash = hash * 59 + this.LastTransactionID.GetHashCode();
                if (this.Trades != null)
                    hash = hash * 59 + this.Trades.GetHashCode();
                if (this.Positions != null)
                    hash = hash * 59 + this.Positions.GetHashCode();
                if (this.Orders != null)
                    hash = hash * 59 + this.Orders.GetHashCode();
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
