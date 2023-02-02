using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_ReyAbdul.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns an input {id}, and applies four mathematical operations to it.
        /// <example>
        /// GET api/NumberMachine/10, GET localhost/NumberMachine/-5, GET localhost/NumberMachine/30
        /// </example>
        /// </summary>
        /// <returns> 28, 13, 48</returns>
        public int Get(int id)
		{
            return id + 20 - 5 * 2 / 4;
		}
    }
}
