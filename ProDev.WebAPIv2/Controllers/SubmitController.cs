using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProDev.WebAPI.Controllers
{
    public class SubmitController : ApiController
    {
        // GET api/email
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/email
        public string Post([FromBody]string value)
        {
            //call next method to send email
            return value;
        }

        // PUT api/email/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/email/5
        public void Delete(int id)
        {
        }
    }
}
