using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_ReyAbdul.Controllers
{
    /// <summary>
    /// This method adds 10 to 'id'
    /// <example>
    /// GET api/AddTend/21, GET localhost/AddTen/0, GET localhost/AddTen/-9
    /// </example>
    /// </summary>
    /// <returns> 31, 10, 1</returns>
    public class AddTenController : ApiController
    {
        public int Get(int id)
		{
            return id + 10;
		}
    }
}
