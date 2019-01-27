// <copyright file="ValuesController.cs" company="Test Company">
// This source code is Copyright © Test Company and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Test Company (www.yourcompany.com).
// </copyright>

namespace WebApplication.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Sample controller.
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// GET api/values.
        /// </summary>
        /// <returns>List of string values.</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        /// <summary>
        /// GET api/values/5.
        /// </summary>
        /// <param name="id">Integer ID.</param>
        /// <returns>String value.</returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// POST api/values.
        /// </summary>
        /// <param name="value">String value.</param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// PUT api/values/5.
        /// </summary>
        /// <param name="id">Integer ID.</param>
        /// <param name="value">String value.</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// DELETE api/values/5.
        /// </summary>
        /// <param name="id">Integer ID.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
