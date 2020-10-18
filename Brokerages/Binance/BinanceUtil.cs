﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using Newtonsoft.Json;
using QuantConnect.Orders;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace QuantConnect.Brokerages.Binance
{
    /// <summary>
    /// Binance utility methods
    /// </summary>
    public class BinanceUtil
    {
        /// <summary>
        /// Convert binance status string value to native Lean OrderStatus
        /// </summary>
        /// <param name="status">The Binance order status value</param>
        /// <returns>Lean order status</returns>
        public static OrderStatus ConvertOrderStatus(string status)
        {
            switch (status.LazyToUpper())
            {
                case "NEW":
                    return OrderStatus.New;
                case "PARTIALLY_FILLED":
                    return OrderStatus.PartiallyFilled;
                case "FILLED":
                    return OrderStatus.Filled;
                case "PENDING_CANCEL":
                    return OrderStatus.CancelPending;
                case "CANCELED":
                    return OrderStatus.Canceled;
                case "REJECTED":
                case "EXPIRED":
                    return OrderStatus.Invalid;
                default:
                    return Orders.OrderStatus.None;
            }
        }
    }
}
