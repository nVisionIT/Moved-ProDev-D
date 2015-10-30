using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDev.Email
{
    public class Email
    {        

        //The ‘To’ and ‘Subject’ fields are required.
        //The ‘To’ fields must be a valid email address format.
        //If the ‘DeliveryType’ field is ‘Email’ use SendGrid to send an email to the address in the ‘To’ field using the ‘Subject’ and ‘Message’ fields for the email’s subject and message.
        //If the ‘DeliveryType’ field is not  ‘Email’ then return a HTTP 501 Exception and write the error to Elmah. 

        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string DeliveryType { get; set; }
    }
}
