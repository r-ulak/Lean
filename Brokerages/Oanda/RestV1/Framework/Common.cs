﻿/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2012-2013 OANDA Corporation
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the "Software"), to deal in the Software without restriction, including without 
 * limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
 * Software, and to permit persons to whom the Software is furnished  to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of 
 * the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE 
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Reflection;

namespace QuantConnect.Brokerages.Oanda.RestV1.Framework
{
#pragma warning disable 1591
    /// <summary>
    /// Common reflection helper methods for Oanda data types.
    /// </summary>
	public class Common
	{
		public static object GetDefault(Type t)
		{
			return typeof(Common).GetTypeInfo().GetDeclaredMethod("GetDefaultGeneric").MakeGenericMethod(t).Invoke(null, null);
		}

		public static T GetDefaultGeneric<T>()
		{
			return default(T);
		}
	}
#pragma warning restore 1591
}
