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

using System.Collections.Generic;
using QuantConnect.Orders.Fees;
using QuantConnect.Securities.Option;

namespace QuantConnect.Orders.OptionExercise
{
    /// <summary>
    /// Represents the default option exercise model (physical, cash settlement)
    /// </summary>
    public class DefaultExerciseModel : IOptionExerciseModel
    {
        /// <summary>
        /// Default option exercise model for the basic equity/index option security class.
        /// </summary>
        /// <param name="option">Option we're trading this order</param>
        /// <param name="order">Order to update</param>
        public IEnumerable<OrderEvent> OptionExercise(Option option, OptionExerciseOrder order)
        {
            var underlying = option.Underlying;

            var isShort = order.Quantity < 0;
            var utcTime = option.LocalTime.ConvertToUtc(option.Exchange.TimeZone);

            var inTheMoney = option.IsAutoExercised(underlying.Close);

            // we're assigned only if we get exercised against, meaning we wrote the option and it was exercised by the buyer
            var isAssignment = inTheMoney && isShort;

            yield return new OrderEvent(
                order.Id,
                option.Symbol,
                utcTime,
                OrderStatus.Filled,
                isShort ? OrderDirection.Buy : OrderDirection.Sell,
                0.0m,
                -order.Quantity,
                OrderFee.Zero,
                // note whether or not we expired OTM/ITM and whether we were assigned or exercised
                inTheMoney ? isAssignment ? "Automatic Assignment" : "Automatic Exercise" : "OTM"
            )
            {
                IsAssignment = isAssignment
            };

            if (inTheMoney && option.ExerciseSettlement == SettlementType.PhysicalDelivery)
            {
                var right = option.Symbol.ID.OptionRight;

                // TODO : Why doesn't this method take into account the directionality of the quantity like other quantity properties/methods
                var fillQuantity = option.GetExerciseQuantity(order.Quantity);
                var exerciseQuantity = right == OptionRight.Call ? fillQuantity : -fillQuantity;

                yield return new OrderEvent(
                    order.Id,
                    underlying.Symbol,
                    utcTime,
                    OrderStatus.Filled,
                    right.GetExerciseDirection(isShort),
                    order.Price,
                    exerciseQuantity,
                    OrderFee.Zero,
                    isAssignment ? "Option Assignment" : "Option Exercise"
                );
            }
        }
    }
}
