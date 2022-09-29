using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01481887.Controllers
{
    public class GreetingController : ApiController
    {   
        /// <summary>
        /// Display a Hello World! Message
        /// </summary>
        /// <returns>Hello World!</returns>
        /// <example>
        /// curl -d "" localhost:54499/api/Greeting
        /// POST: api/Greeting/Greeting -> "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Display a Hello World! Message
        /// </summary>
        /// <returns>Hello World!</returns>
        /// <example>
        /// GET:/api/Gretting/3 --> Greeting to 3 People!
        /// GET:/api/Greeting/6 --> Greeting to 6 People!
        /// GET:/api/Greeting/0 --> Greeting to 0 People!
        /// </example>
        public string Get(int id)
        {
            return "Greeting" + " to " + id + " People!";
        }
    }
}
