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
    /// The type of an Instrument.
    /// </summary>
    /// <value>The type of an Instrument.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstrumentType
    {
        
        /// <summary>
        /// Enum CURRENCY for "CURRENCY"
        /// </summary>
        [EnumMember(Value = "CURRENCY")]
        CURRENCY,
        
        /// <summary>
        /// Enum CFD for "CFD"
        /// </summary>
        [EnumMember(Value = "CFD")]
        CFD,
        
        /// <summary>
        /// Enum METAL for "METAL"
        /// </summary>
        [EnumMember(Value = "METAL")]
        METAL
    }

}
