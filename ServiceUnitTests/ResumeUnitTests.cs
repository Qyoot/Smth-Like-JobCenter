using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessLogicLayer;
using Services;
using Services.Abstract;
using System.Collections.Generic;

namespace ServiceUnitTests
{
    [TestClass]
    public class ResumeUnitTest
    {
        [TestMethod]
        public void SaveTestResume()
        {
            string path = @"D:\ForFiles\UnitTest";
            var mock = new Mock<IResumeService>();
            mock.Setup(obj => obj.Save(path, new List<Resume>()));

            IResumeService service = mock.Object;
            service.Save(path, new List<Resume>());
        }

        [TestMethod]
        public void DeserializaeTestResume()
        {
            var resume = new Resume(new Person("Nick", "Grdon", "Leiv", "Male"),false,false,0,"zero","IT",0);
            string path = @"D:\ForFiles\UnitTTest";

            ResumeService personService = new ResumeService();
            personService.Save(path, new List<Resume> { resume });
            var result = personService.ToDeserialzie(path);

            Assert.AreEqual(resume.Sphere, result[0].Sphere);
        }

        [TestMethod]
        public void ResumePropertyAboutPerson()
        {
            var test = "Test";
            var resume = new Resume();
            resume.About_person= test;
            Assert.AreEqual(test, resume.About_person);
        }

        [TestMethod]
        public void ResumePropertyEngKnowFalse()
        {
            var test = false;
            var resume = new Resume();
            resume.Eng_knowledge = test;
            Assert.AreEqual(test, resume.Eng_knowledge);
        }

        [TestMethod]
        public void ResumePropertyEngKnowTrue()
        {
            var test = true;
            var resume = new Resume();
            resume.Eng_knowledge = test;
            Assert.AreEqual(test, resume.Eng_knowledge);
        }

        [TestMethod]
        public void ResumePropertySallary()
        {
            var test = 1000;
            var resume = new Resume();
            resume.Expected_sallary = test;
            Assert.AreEqual(test, resume.Expected_sallary);
        }

        [TestMethod]
        public void ResumePropertyExp()
        {
            var test = 12;
            var resume = new Resume();
            resume.Experience = test;
            Assert.AreEqual(test, resume.Experience);
        }

        [TestMethod]
        public void ResumePropertyEducationFalse()
        {
            var test = false;
            var resume = new Resume();
            resume.Higher_education = test;
            Assert.AreEqual(test, resume.Higher_education);
        }

        [TestMethod]
        public void ResumePropertyEducationtrue()
        {
            var test = true;
            var resume = new Resume();
            resume.Higher_education = test;
            Assert.AreEqual(test, resume.Higher_education);
        }

        [TestMethod]
        public void ResumePropertySphere()
        {
            var test = "IT";
            var resume = new Resume();
            resume.Sphere = test;
            Assert.AreEqual(test, resume.Sphere);
        }

        [TestMethod]
        public void ResumePropertyPerson()
        {
            var test = new Person("N","A","M","Female");
            var resume = new Resume();
            resume.Person = test;
            Assert.AreEqual(test.First_Name, resume.Person.First_Name);
        }

        [TestMethod]
        public void ResumeToString()
        {
            var firm = new Resume();
            string expected = "BusinessLogicLayer.Resume";
            var str = firm.ToString();
            Assert.AreEqual(expected, str);
        }
    }
}
