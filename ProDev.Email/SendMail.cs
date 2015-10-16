using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using SendGrid;

namespace ProDev.Email
{
    public class SendMail
    {

        public bool SendEmail(Email email)
        {
           var api_user = "azure_b6fd836b823370112551bed19878ab09@azure.com";
           var api_key = "JfMBJ1lQ373TrbA";

            SendGridMessage mail = new SendGridMessage();
            mail.From = new MailAddress("test@nvisionit.co.za");
            mail.AddTo(email.To);
            mail.Subject = email.Subject;
            mail.Text = email.Message;

            var credentials = new NetworkCredential(api_user, api_key);
            var transportWeb = new Web(credentials);
            transportWeb.DeliverAsync(mail);
            // If developing a Console Application, use the following
            // transportWeb.DeliverAsync(mail).Wait();
            return true;
        }
    }
}
