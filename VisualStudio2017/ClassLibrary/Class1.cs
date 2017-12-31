// <copyright file="Class1.cs" company="Test Company">
// This source code is Copyright © Test Company and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Test Company (www.yourcompany.com).
// </copyright>

namespace ClassLibrary
{
    using System;

    /// <inheritdoc />
    public class Class1 : IClass1
    {
        /// <inheritdoc />
        public string GetTestStats()
        {
            return $"{nameof(GetTestStats)} method was called at {DateTime.Now}";
        }
    }
}
