// <copyright file="Program.cs" company="Test Company">
// This source code is Copyright © Test Company and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Test Company (www.yourcompany.com).
// </copyright>

namespace ConsoleApp
{
    using System;
    using ClassLibrary;

    /// <summary>
    /// The main program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">Program arguments</param>
        public static void Main(string[] args)
        {
            var class1 = new Class1();

            Console.WriteLine(class1.GetTestStats());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
