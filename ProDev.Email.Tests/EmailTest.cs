using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProDev.Email.Tests
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void SendEmail()
        {
            Email.SendGrid sendGrid = new Email.SendGrid();
            Assert.IsTrue(sendGrid.SendEmail());
        }
    }
}
