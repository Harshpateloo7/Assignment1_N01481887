using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01481887.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// It will calcualte the total cost as per number of days that is {id}
        /// </summary>
        /// <param name="id">Represents number of days</param> 
        /// <returns>Reterns string with totoal cost of hosting with days </returns>
        /// <example>
        /// GET: /api/HostingCost/0  -> 1 fortnights at $5.50/FN = $5.50 CAD,HST 13% = $0.72 CAD, Total = $6.22 CAD
        /// GET: /api/HostingCost/14 -> 2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD 
        /// GET: /api/HostingCost/15 -> 2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD
        /// GET: /api/HostingCost/21 -> 2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD, Total = $12.43 CAD
        /// GET: /api/HostingCost/28 -> 3 fortnights at $5.50/FN = $16.50 CAD, HST 13% = $2.14 CAD, Total = $18.64 CAD
        /// </example>
        public IEnumerable<string> GET(int id)
        {
            int fortnight = id / 14 + 1;
            double perNight = 5.50;
            double HST = 0.13;
            double totalTax = 1.13;
            double costWithoutTax = fortnight * perNight;
            double hstAmount = HST* costWithoutTax;
            double totalAmount = totalTax * costWithoutTax;
            return new string[] { "1 fortnights at $5.50/FN = " + costWithoutTax + " CAD ", "HST 13% =" + hstAmount + " CAD ", " Total =" + totalAmount + " CAD " };

        }
    }
}
