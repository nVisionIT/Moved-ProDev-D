using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProDev.Email.Tests
{
    [TestClass]
    public class EmailClassTest
    {
        
        [TestMethod]
        public void TestClass(Email email)
        {
             email = new Email() { To = "rehanav@nvisionit.co.za", Subject = "Unit Test", DeliveryType = "Email", Message = "Test" };
            Assert.IsNotNull(email.To);
            Assert.IsNotNull(email.Subject);

            if (email.DeliveryType != "Email")
            {
                throw new Exception("Delivery Type not email");
            }
            
        }
    }
}
