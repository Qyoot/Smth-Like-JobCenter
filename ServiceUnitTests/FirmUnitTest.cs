using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessLogicLayer;
using Services;
using Services.Abstract;
using System.Collections.Generic;

namespace ServiceUnitTests
{
    
    [TestClass]
    public class FirmUnitTest
    {
        [TestMethod]
        public void SaveTestFirm()
        {
            string path = @"D:\ForFiles\UnitTest";
            var mock = new Mock<IFirmService>();
            mock.Setup(obj => obj.Save(path, new List<Firm>()));

            IFirmService service = mock.Object;
            service.Save(path, new List<Firm>());
        }

        [TestMethod]
        public void DeserializaeTestFirm()
        {
            var firm = new Firm("Firm", "IT", 10, 2);
            string path = @"D:\ForFiles\UnitTest";

            FirmService firmService = new FirmService();
            firmService.Save(path, new List<Firm> { firm });
            var result = firmService.ToDeserialzie(path);

            Assert.AreEqual(firm.Name, result[0].Name);
        }

        [TestMethod]
        public void FirmToString()
        {
            var firm = new Firm("Firm", "IT", 10, 2);
            string expected = "BusinessLogicLayer.Firm";
            var str = firm.ToString();
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void FirmPropertyName()
        {
            var test = "Test";
            var firm = new Firm();
            firm.Name = test;
            Assert.AreEqual(test, firm.Name);
        }

        [TestMethod]
        public void FirmPropertyMarketExp()
        {
            var test = 0;
            var firm = new Firm();
            firm.Market_experience = test;
            Assert.AreEqual(test, firm.Market_experience);
        }

        [TestMethod]
        public void FirmPropertySphere()
        {
            var test = "Test";
            var firm = new Firm();
            firm.Sphere = test;
            Assert.AreEqual(test, firm.Sphere);
        }

        [TestMethod]
        public void FirmPropertyQuantityOfEmployee()
        {
            var test = 2;
            var firm = new Firm();
            firm.Quantity_of_employee = test;
            Assert.AreEqual(test, firm.Quantity_of_employee);
        }
    }
}

