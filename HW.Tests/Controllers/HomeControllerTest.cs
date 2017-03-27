using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW;
using HW.Controllers;

namespace HW.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            string result = controller.Index() as string;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World!", result);
        }
    }
}
