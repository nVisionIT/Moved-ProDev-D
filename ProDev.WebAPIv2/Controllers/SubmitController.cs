using ProDev.WebAPIv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
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
        public HttpResponseMessage Post([FromBody]Email.Email model)
        {
            var response = new HttpResponseMessage();
            //call next method to send email
            if (model != null)
            {
                Email.SendMail sendMail = new Email.SendMail();

                //validate json data/model and return response
                var modelValidated = ValidateEmail.ValidateModel(model);
                if (modelValidated.StatusCode != HttpStatusCode.OK)
                {
                    //validation failed
                    response = modelValidated;
                }
                else
                {
                    //validation passed
                    if (sendMail.SendEmail(model))
                    {
                        response.StatusCode = HttpStatusCode.OK;
                        response.ReasonPhrase = "Your message has been sent.";
                    }
                    else
                    {
                        response.StatusCode = HttpStatusCode.InternalServerError;
                        response.ReasonPhrase = "Your message was NOT sent.";
                    }
                }
            }
            return response;
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
