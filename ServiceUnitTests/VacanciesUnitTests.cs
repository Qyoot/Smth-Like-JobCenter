using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessLogicLayer;
using Services;
using Services.Abstract;
using System.Collections.Generic;

namespace ServiceUnitTests
{
    [TestClass]
   public class VacanciesUnitTests
    {
        [TestMethod]
        public void SaveTestVacancy()
        {
            string path = @"D:\ForFiles\UnitTest";
            var mock = new Mock<IVacanciesService>();
            mock.Setup(obj => obj.Save(path, new List<Vacancies>()));

            IVacanciesService service = mock.Object;
            service.Save(path, new List<Vacancies>());
        }

        [TestMethod]
        public void DeserializaeTestVacancy()
        {
            var vacancies = new Vacancies(new Firm("na","str",2,2),"IT","City",false,false,0,0);
            string path = @"D:\ForFiles\UnitTTest";

            VacanciesService personService = new VacanciesService();
            personService.Save(path, new List<Vacancies> { vacancies });
            var result = personService.ToDeserialzie(path);

            Assert.AreEqual(vacancies.Sphere, result[0].Sphere);
        }

        [TestMethod]
        public void VacanciesPropertyAddress()
        {
            var test = "Test";
            var vacancies = new Vacancies();
            vacancies.Address = test;
            Assert.AreEqual(test, vacancies.Address);
        }

        [TestMethod]
        public void VacanciesPropertyEngKnowFalse()
        {
            var test = false;
            var vacancies = new Vacancies();
            vacancies.Eng_knowledge = test;
            Assert.AreEqual(test, vacancies.Eng_knowledge);
        }

        [TestMethod]
        public void VacanciesPropertyEngKnowTrue()
        {
            var test = true;
            var vacancies = new Vacancies();
            vacancies.Eng_knowledge = test;
            Assert.AreEqual(test, vacancies.Eng_knowledge);
        }

        [TestMethod]
        public void VacanciesPropertySallary()
        {
            var test = 3;
            var resume = new Vacancies();
            resume.Sallary = test;
            Assert.AreEqual(test, resume.Sallary);
        }

        [TestMethod]
        public void VacanciesPropertyExp()
        {
            var test = 12;
            var vacancies = new Vacancies();
            vacancies.Experience = test;
            Assert.AreEqual(test, vacancies.Experience);
        }

        [TestMethod]
        public void VacanciesPropertyEducationFalse()
        {
            var test = false;
            var vacancies = new Vacancies();
            vacancies.Higher_education = test;
            Assert.AreEqual(test, vacancies.Higher_education);
        }

        [TestMethod]
        public void VacanciesPropertyEducationTrue()
        {
            var test = true;
            var vacancies = new Vacancies();
            vacancies.Higher_education = test;
            Assert.AreEqual(test, vacancies.Higher_education);
        }

        [TestMethod]
        public void VacanciesPropertySphere()
        {
            var test = "IT";
            var vacancies = new Vacancies();
            vacancies.Sphere = test;
            Assert.AreEqual(test, vacancies.Sphere);
        }

        [TestMethod]
        public void FirmPropertyPerson()
        {
            var test = new Firm("na", "str", 2, 2);
            var resume = new Vacancies();
            resume.Firm = test;
            Assert.AreEqual(test.Name, resume.Firm.Name);
        }

        [TestMethod]
        public void FirmToString()
        {
            var firm = new Vacancies();
            string expected = "BusinessLogicLayer.Vacancies";
            var str = firm.ToString();
            Assert.AreEqual(expected, str);
        }
    }
}
