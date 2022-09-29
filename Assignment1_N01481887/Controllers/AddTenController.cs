using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01481887.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns sum with input id value + value 10.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Add 10 into a id</returns>
        /// <example>
        /// GET :/api/AddTen/21 -> 31
        /// GET :/api/AddTen/0  -> 10
        /// GET :/api/AddTen/-9 -> 1
        /// </example>
        public int GET(int id)
        {
            int sum = id + 10 ;
            return sum;
        }
    }
}
