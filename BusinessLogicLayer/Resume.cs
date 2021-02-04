namespace BusinessLogicLayer
{
    public class Resume
    {
        private Person person;
        private bool higher_education;
        private bool eng_knowledge;
        private int experience;
        private string about_person;
        private string sphere; 
        private int expected_sallary;


        public int Experience { get => experience; set => experience = value; }
        public bool Eng_knowledge { get => eng_knowledge; set => eng_knowledge = value; }
        public string About_person { get => about_person; set => about_person = value; }
        public bool Higher_education { get => higher_education; set => higher_education = value; }
        public string Sphere { get => sphere; set => sphere = value; }
        public int Expected_sallary { get => expected_sallary; set => expected_sallary = value; }
        public Person Person { get => person; set => person = value; }

        public Resume()
        {
            person = null;
            higher_education = false;
            eng_knowledge = false;
            experience = 0;
            about_person = null;
            sphere = null;
            expected_sallary = 0;
        }

        public Resume(Person person, bool higher_education, bool eng_knowledge, int experience, string about_person, string sphere, int expected_sallary)
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
