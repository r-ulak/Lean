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
    /// The type of the Order.
    /// </summary>
    /// <value>The type of the Order.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderType
    {
        
        /// <summary>
        /// Enum MARKET for "MARKET"
        /// </summary>
        [EnumMember(Value = "MARKET")]
        MARKET,
        
        /// <summary>
        /// Enum LIMIT for "LIMIT"
        /// </summary>
        [EnumMember(Value = "LIMIT")]
        LIMIT,
        
        /// <summary>
        /// Enum STOP for "STOP"
        /// </summary>
        [EnumMember(Value = "STOP")]
        STOP,
        
        /// <summary>
        /// Enum MARKETIFTOUCHED for "MARKET_IF_TOUCHED"
        /// </summary>
        [EnumMember(Value = "MARKET_IF_TOUCHED")]
        MARKETIFTOUCHED,
        
        /// <summary>
        /// Enum TAKEPROFIT for "TAKE_PROFIT"
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT")]
        TAKEPROFIT,
        
        /// <summary>
        /// Enum STOPLOSS for "STOP_LOSS"
        /// </summary>
        [EnumMember(Value = "STOP_LOSS")]
        STOPLOSS,
        
        /// <summary>
        /// Enum TRAILINGSTOPLOSS for "TRAILING_STOP_LOSS"
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS")]
        TRAILINGSTOPLOSS
    }

}
