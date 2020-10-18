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
    /// Specification of how Positions in the Account are modified when the Order is filled.
    /// </summary>
    /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderPositionFill
    {
        
        /// <summary>
        /// Enum OPENONLY for "OPEN_ONLY"
        /// </summary>
        [EnumMember(Value = "OPEN_ONLY")]
        OPENONLY,
        
        /// <summary>
        /// Enum REDUCEFIRST for "REDUCE_FIRST"
        /// </summary>
        [EnumMember(Value = "REDUCE_FIRST")]
        REDUCEFIRST,
        
        /// <summary>
        /// Enum REDUCEONLY for "REDUCE_ONLY"
        /// </summary>
        [EnumMember(Value = "REDUCE_ONLY")]
        REDUCEONLY,
        
        /// <summary>
        /// Enum DEFAULT for "DEFAULT"
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Enum POSITIONDEFAULT for "POSITION_DEFAULT"
        /// </summary>
        [EnumMember(Value = "POSITION_DEFAULT")]
        POSITIONDEFAULT
    }

}
