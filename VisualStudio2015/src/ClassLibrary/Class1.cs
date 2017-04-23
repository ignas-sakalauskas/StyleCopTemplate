// <copyright file="Class1.cs" company="Test Company">
// This source code is Copyright © Test Company and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Test Company (www.yourcompany.com).
// </copyright>

namespace ClassLibrary
{
    using System;

    /// <summary>
    /// Simple test class
    /// </summary>
    public class Class1 : IClass1
    {
        /// <summary>
        /// Test method to return non-empty text string
        /// </summary>
        /// <returns>A string contianng a name of this method, and when it was called</returns>
        public string GetTestStats()
        {
            // Nihon - testing custom Style Cop dictionary
            return $"{nameof(GetTestStats)} method was called at {DateTime.Now}";
        }
    }
}
