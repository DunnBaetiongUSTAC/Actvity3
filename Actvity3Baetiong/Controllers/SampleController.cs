using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Actvity3Baetiong.Controllers
{
    public class SampleController : ApiController
    {
    
        public string Get()
        {
            return "im a GET Operation";
        }

        public string Get(int age)
        {
            return "im a GET Operation with a paremeter value of "+ age;
        }
        public string Post()
        {
            return "im a POST Operation";
        }

        public string Put()
        {
            return "im a PUT Operation";
        }

        public string Delete()
        {
            return "im a DELETE Operation";
        }

    }
}
