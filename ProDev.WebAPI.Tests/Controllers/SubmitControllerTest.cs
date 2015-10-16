﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProDev.WebAPI;
using ProDev.WebAPI.Controllers;

namespace ProDev.WebAPI.Tests.Controllers
{
    [TestClass]
    public class SubmitControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            SubmitController controller = new SubmitController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            SubmitController controller = new SubmitController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            SubmitController controller = new SubmitController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            SubmitController controller = new SubmitController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            SubmitController controller = new SubmitController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
