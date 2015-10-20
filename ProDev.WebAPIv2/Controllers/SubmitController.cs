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
            return new string[] { "You", "are", "not", "supposed", "to", "do", "a", "get", "to", "here" };
        }

        // GET api/email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/email
        public void Post([FromBody]Email.Email value)
        {
            //call next method to send email
            if (value != null)
            {
                Email.SendMail sendMail = new Email.SendMail();
                sendMail.SendEmail(value);
            }
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
