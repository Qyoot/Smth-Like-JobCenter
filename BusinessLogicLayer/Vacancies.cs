namespace BusinessLogicLayer
{
    public class Vacancies
    {
        private Firm firm;
        private bool higher_education;
        private bool eng_knowledge;
        private int experience;
        private string sphere;
        private string address;
        private int expected_sallary;

        
        public string Sphere { get => sphere; set => sphere = value; }
        public bool Eng_knowledge { get => eng_knowledge; set => eng_knowledge = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Sallary { get => expected_sallary; set => expected_sallary = value; }
        public string Address { get => address; set => address = value; }
        public bool Higher_education { get => higher_education; set => higher_education = value; }
        public Firm Firm { get => firm; set => firm = value; }

        public Vacancies( Firm firm, string sphere, string address, bool higher_education, bool eng_knowledge, int experience, int sallary)
        {
            Firm = firm;
            Sphere = sphere;
            Address = address;
            Higher_education = higher_education;
            Eng_knowledge = eng_knowledge;
            Experience = experience;
            Sallary = sallary;
        }

        public Vacancies()
        {
            this.Firm = null;
            Sphere = null;
            Address = null;
            Higher_education = false;
            Eng_knowledge = false;
            Experience = 0;
            Sallary = 0;
        }
    }
}
