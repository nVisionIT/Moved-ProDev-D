using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;

namespace ProDev.WebAPIv2.Models
{
    public class ValidateEmail
    {
        public static HttpResponseMessage ValidateModel(Email.Email model)
        {
            var response = new HttpResponseMessage();
            if (!model.DeliveryType.Trim().ToLower().Equals("email"))
            {
                response.StatusCode = HttpStatusCode.NotImplemented;
                response.ReasonPhrase = string.Format("The DeliveryType [{0}] is not implemented.", model.DeliveryType);
                Elmah.ErrorLog.GetDefault(HttpContext.Current).Log(new Elmah.Error(new Exception(string.Format("The DeliveryType [{0}] is not implemented.", model.DeliveryType))));
            }

            if (string.IsNullOrWhiteSpace(model.To))
            {
                response.ReasonPhrase = "The \"To\" value is required";
                response.StatusCode = HttpStatusCode.BadRequest;
            }

            if (string.IsNullOrWhiteSpace(model.Subject))
            {
                response.ReasonPhrase = "The \"Subject\" value is required";
                response.StatusCode = HttpStatusCode.BadRequest;
            }

            try
            {
                var mailAddress = new MailAddress(model.To);
            }
            catch (FormatException)
            {
                response.ReasonPhrase = "The \"To\" value is not a valid email address";
                response.StatusCode = HttpStatusCode.BadRequest;
            }
            return response;
        }
    }
}