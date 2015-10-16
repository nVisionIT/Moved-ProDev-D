using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDev.Email
{
    public class Email
    {        
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string DeliveryType { get; set; }        
    }
}
