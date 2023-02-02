using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_ReyAbdul.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string “Hello World!”.
        /// <example>
        /// POST api/Greeting
        /// </example>
        /// </summary>
        /// <returns> "Hello World!"</returns>
        public string POST()
		{
            return "Hello World!";
		}


        /// <summary>
        /// This method returns the string “Greetings to {id} people!” where id is an integer value.
        /// <example>
        /// Get api/Greeting/3, Get api/Greeting/6, Get api/Greeting/0
        /// </example>
        /// </summary>
        /// <returns>“Greetings to 3 people!”, “Greetings to 6 people!”, “Greetings to 0 people!” </returns>
        public string Get(int id)
		{
            return $"Greetings to {id} people";
		}
    }
}
