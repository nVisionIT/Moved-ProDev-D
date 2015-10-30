using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProDev.WebAPI.Controllers;

namespace ProDev.Email.Tests
{
    [TestClass]
    public class EmailClassTest
    {
        
        [TestMethod]
        public void TestEmailClass()
        {
            Email email = new Email() { To = "rehanav@nvisionit.co.za", Subject = "Unit Test", DeliveryType = "Email", Message = "Test" };
            Assert.IsNotNull(email.To);
            Assert.IsNotNull(email.Subject);

            if (email.DeliveryType != "Email")
            {
                throw new Exception("Delivery Type not email");
            }
            
        }

        //[TestMethod]
        //public void TestEmailValidation()
        //{
        //    Email email = new Email() { To = "rehanav@@nvisionit.co.za", Subject = "Unit Test", DeliveryType = "Email", Message = "Test" };

        //    SubmitController controller = new SubmitController();
            
        //    Assert.IsTrue();
       //}

        [TestMethod]
        public void TestSubject()
        {
            Email email = new Email() { To = "rehanav@@nvisionit.co.za", Subject = "", DeliveryType = "Email", Message = "Test" };

            SendMail sendMail = new SendMail();
            Assert.IsTrue(sendMail.SendEmail(email));

        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestDeliveryType()
        //{
        //    Email email = new Email() { To = "rehanav@@nvisionit.co.za", Subject = "Unit Test", DeliveryType = "", Message = "Test" };          
        //}
    }
}
