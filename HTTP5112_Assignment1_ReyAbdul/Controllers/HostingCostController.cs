using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_ReyAbdul.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method output 3 strings which describe the total hosting cost.
            /// <example>
            /// GET api/HostingCost/0,
            /// GET api/HostingCost/14,
            /// GET api/HostingCost/15,
            /// GET api/HostingCost/21,
            /// GET api/HostingCost/28,
            /// </example>
        /// </summary>
        /// <returns>
        ///  	“1 fortnights at $5.50/FN = $5.50 CAD” “HST 13% = $0.72 CAD” “Total = $6.22 CAD”
        ///  	“2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
        ///  	“2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
        ///  	“2 fortnights at $5.50/FN = $11.00 CAD” “HST 13% = $1.43 CAD” “Total = $12.43 CAD”
        ///  	“3 fortnights at $5.50/FN = $16.50 CAD” “HST 13% = $2.14 CAD” “Total = $18.64 CAD”
        /// </returns>

        public IEnumerable<string> Get(int id)
        {
            //---------listing all variables------
            int fortnight = 14;
            double price = 5.50;
            
            //whether it 0 or 13 days, it will be counted as 1 fornight, add it to input{id} and devide by fornight to get # of fornights 
            int totalFortnites = (fortnight + id) / fortnight;

            //Total price before tax
            double totalBeforeTaxes = totalFortnites * price;

            //hst and calcHst(calculating the hst only for price)
            double hst = 0.13;
            double calcHst = Math.Round(totalBeforeTaxes * hst, 2);

            //Total with taxes
            double total = Math.Round(totalBeforeTaxes + calcHst, 2);

            return new string[]
            {
                $"{totalFortnites} fortnights at {price}/FN = ${totalBeforeTaxes} CAD",
                $"HST {hst}% = ${calcHst} CAD",
                $"Total = ${total} CAD"
            };
     
		}


        
    }
}
