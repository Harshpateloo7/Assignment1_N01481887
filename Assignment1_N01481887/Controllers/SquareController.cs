using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01481887.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the integer input id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>multiply id with input id</returns>
        /// <example>
        /// GET :/api/Square/2 -> 4
        /// GET :/api/Square/-2 -> 4
        /// GET :/api/Square/10 -> 100
        /// </example>
        public int GET(int id)
        {
            int square = id * id;
            return square;
        }
    }
}

