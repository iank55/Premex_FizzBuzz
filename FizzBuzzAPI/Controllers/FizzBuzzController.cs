using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FizzBuzzAPI.Controllers
{
    public class FizzBuzzController : ApiController
    {
        public string[] Get()
        {
            List<string> retList = new List<string>();
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            for (int id = 1; id <= 100; id++)
            {
                retList.Add(fizzBuzzEngine.ConvertToFizzBuzz(id));
            }
            return retList.ToArray();
        }

        public string Get([FromUri] int id)
        {
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();
            return fizzBuzzEngine.ConvertToFizzBuzz(id);
        }

    }
}
