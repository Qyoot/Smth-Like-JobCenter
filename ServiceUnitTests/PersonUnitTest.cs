using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessLogicLayer;
using Services;
using Services.Abstract;
using System.Collections.Generic;

namespace ServiceUnitTests
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void SaveTestPerson()
        {
            string path = @"D:\ForFiles\UnitTest";
            var mock = new Mock<IPersonService>();
            mock.Setup(obj => obj.Save(path, new List<Person>()));

            IPersonService service = mock.Object;
            service.Save(path, new List<Person>());
        }

        [TestMethod]
        public void DeserializaeTestPerson()
        {
            var person = new Person("Nick","Grdon","Leiv","Male");
            string path = @"D:\ForFiles\UnitTTest";

            PersonService personService = new PersonService();
            personService.Save(path, new List<Person> { person });
            var result = personService.ToDeserialzie(path);

            Assert.AreEqual(person.City, result[0].City);
        }

        [TestMethod]
        public void FirmPropertyName()
        {
            var test = "Test";
            var firm = new Person();
            firm.First_Name = test;
            Assert.AreEqual(test, firm.First_Name);
        }

        [TestMethod]
        public void FirmPropertySecondName()
        {
            var test = "Test";
            var person = new Person();
            person.Second_Name = test;
            Assert.AreEqual(test, person.Second_Name);
        }

        [TestMethod]
        public void FirmPropertyGender()
        {
            var test = "Test";
            var person = new Person();
            person.Gender = test;
            Assert.AreEqual(test, person.Gender);
        }

        [TestMethod]
        public void FirmPropertyCity()
        {
            var test = "2";
            var person = new Person();
            person.City = test;
            Assert.AreEqual(test, person.City);
        }

        [TestMethod]
        public void PersonToString()
        {
            var firm = new Person();
            string expected = "BusinessLogicLayer.Person";
            var str = firm.ToString();
            Assert.AreEqual(expected, str);
        }
    }
}
