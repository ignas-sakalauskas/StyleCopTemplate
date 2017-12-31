// <copyright file="Program.cs" company="Test Company">
// This source code is Copyright © Test Company and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Test Company (www.yourcompany.com).
// </copyright>

namespace WebApplication
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// The main program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">Program arguments</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            await BuildWebHost(args).RunAsync();
        }

        /// <summary>
        /// Gets an instance of <see cref="IWebHost"/>
        /// </summary>
        /// <param name="args">Program arguments</param>
        /// <returns><see cref="IWebHost"/></returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}