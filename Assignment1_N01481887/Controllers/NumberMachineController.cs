using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01481887.Controllers
{
    public class NumberMachineController : ApiController   
    {
        /// <summary>
        /// Perform arithmetic like +, -, *, / operation and returns value
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Reurn the value of arithmetic operation</returns>
        /// <example>
        /// GET: /api/NumberMachine/10 -- > 1
        /// GET: /api/NumberMachine/-5 -> 0
        /// GET: /api/NumberMachine/30 -> 3
        /// </example>
        public int GET(int id)
        {   
            int sum = id + 10;
            int sub = sum - 5;
            int mul = sub * 10;
            int div = mul / 100;
            return div;
           
        }
    }
}
