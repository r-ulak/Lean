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
    /// The financing mode of an Account
    /// </summary>
    /// <value>The financing mode of an Account</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountFinancingMode
    {
        
        /// <summary>
        /// Enum NOFINANCING for "NO_FINANCING"
        /// </summary>
        [EnumMember(Value = "NO_FINANCING")]
        NOFINANCING,
        
        /// <summary>
        /// Enum SECONDBYSECOND for "SECOND_BY_SECOND"
        /// </summary>
        [EnumMember(Value = "SECOND_BY_SECOND")]
        SECONDBYSECOND,
        
        /// <summary>
        /// Enum DAILY for "DAILY"
        /// </summary>
        [EnumMember(Value = "DAILY")]
        DAILY
    }

}
