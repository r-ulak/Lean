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
 *
*/

using QuantConnect.Data;
using QuantConnect.Packets;

namespace QuantConnect.Interfaces
{
    /// <summary>
    /// Entity in charge of handling data permissions
    /// </summary>
    public interface IDataPermissionManager
    {
        /// <summary>
        /// The data channel provider instance
        /// </summary>
        IDataChannelProvider DataChannelProvider { get; }

        /// <summary>
        /// Initialize the data permission manager
        /// </summary>
        /// <param name="job">The job packet</param>
        void Initialize(AlgorithmNodePacket job);

        /// <summary>
        /// Will assert the requested configuration is valid for the current job
        /// </summary>
        /// <param name="subscriptionDataConfig">The data subscription configuration to assert</param>
        void AssertConfiguration(SubscriptionDataConfig subscriptionDataConfig);

        /// <summary>
        /// Gets a valid resolution to use for internal subscriptions
        /// </summary>
        /// <returns>A permitted resolution for internal subscriptions</returns>
        Resolution GetResolution(Resolution preferredResolution);
    }
}
