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

using System;
using QuantConnect.Scheduling;

namespace QuantConnect.Exceptions
{
    /// <summary>
    /// Interprets <see cref="ScheduledEventException"/> instances
    /// </summary>
    public class ScheduledEventExceptionInterpreter : IExceptionInterpreter
    {
        /// <summary>
        /// Determines the order that an instance of this class should be called
        /// </summary>
        public int Order => 0;

        /// <summary>
        /// Determines if this interpreter should be applied to the specified exception.
        /// </summary>
        /// <param name="exception">The exception to check</param>
        /// <returns>True if the exception can be interpreted, false otherwise</returns>
        public bool CanInterpret(Exception exception) => exception?.GetType() == typeof(ScheduledEventException);

        /// <summary>
        /// Interprets the specified exception into a new exception
        /// </summary>
        /// <param name="exception">The exception to be interpreted</param>
        /// <param name="innerInterpreter">An interpreter that should be applied to the inner exception.
        /// This provides a link back allowing the inner exceptions to be interpreted using the interpreters
        /// configured in the <see cref="IExceptionInterpreter"/>. Individual implementations *may* ignore
        /// this value if required.</param>
        /// <returns>The interpreted exception</returns>
        public Exception Interpret(Exception exception, IExceptionInterpreter innerInterpreter)
        {
            var see = (ScheduledEventException) exception;

            var inner = innerInterpreter.Interpret(see.InnerException, innerInterpreter);

            // prepend the scheduled event name
            var message = exception.Message;
            if (!message.Contains(see.ScheduledEventName))
            {
                message = $"In Scheduled Event '{see.ScheduledEventName}',";
            }

            return new ScheduledEventException(see.ScheduledEventName, message, inner);
        }
    }
}