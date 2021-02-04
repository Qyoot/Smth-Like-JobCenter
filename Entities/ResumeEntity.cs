using System;

namespace Entities
{
    [Serializable]
    public class ResumeEntity 
    {
        PersonEntity person;
        private bool higher_education;
        private bool eng_knowledge;
        private int experience;
        private string about_person;
        private string sphere;
        private int expected_sallary;
        
        public bool Higher_education { get => higher_education; set => higher_education = value; }
        public bool Eng_knowledge { get => eng_knowledge; set => eng_knowledge = value; }
        public int Experience { get => experience; set => experience = value; }
        public string About_person { get => about_person; set => about_person = value; }
        public string Sphere { get => sphere; set => sphere = value; }
        public int Expected_sallary { get => expected_sallary; set => expected_sallary = value; }
        public PersonEntity Person { get => person; set => person = value; }

        public ResumeEntity()
        {
            person = null;
            higher_education = false;
            eng_knowledge = false;
            experience = 0;
            about_person = null;
        }

        public ResumeEntity(PersonEntity person, bool higher_education, bool eng_knowledge, int experience, string about_person, string sphere, int expected_sallary)
        {
            this.person = person;
            this.higher_education = higher_education;
            this.eng_knowledge = eng_knowledge;
            this.experience = experience;
            this.about_person = about_person;
            this.sphere = sphere;
            this.expected_sallary = expected_sallary;
        }
    }
}
