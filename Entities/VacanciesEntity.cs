using System;

namespace Entities
{
    [Serializable]
    public class VacanciesEntity     
    {
        private FirmEntity firm;
        private string sphere;
        private string address;
        private bool higher_education;
        private bool eng_knowledge;
        private int experience;
        private int sallary;
 
        public string Sphere { get => sphere; set => sphere = value; }
        public string Address { get => address; set => address = value; }
        public bool Higher_education { get => higher_education; set => higher_education = value; }
        public bool Eng_knowledge { get => eng_knowledge; set => eng_knowledge = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Sallary { get => sallary; set => sallary = value; }
        public FirmEntity Firm { get => firm; set => firm = value; }

        public VacanciesEntity()
        {
            firm = null;
            sphere = null;
            address = null;
            higher_education = false;
            eng_knowledge = false;
            experience = 0;
            sallary = 0;
        }

        public VacanciesEntity(FirmEntity firm, string sphere, string address, bool higher_education, bool eng_knowledge, int experience, int sallary)
        {
            this.firm = firm;
            this.sphere = sphere;
            this.address = address;
            this.higher_education = higher_education;
            this.eng_knowledge = eng_knowledge;
            this.experience = experience;
            this.sallary = sallary;
        }
    }
}
