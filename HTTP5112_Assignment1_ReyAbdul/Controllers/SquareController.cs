using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_ReyAbdul.Controllers
{
    /// <summary>
    /// This method returns a squared output to 'id'
    /// <example>
    /// GET api/Square/2, GET localhost/Square/-2, GET localhost/Square/10
    /// </example>
    /// </summary>
    /// <returns> 4, 4, 100</returns>
    public class SquareController : ApiController
    {
        public int Get(int id)
		{
            return id * id;
		}
    }
}
