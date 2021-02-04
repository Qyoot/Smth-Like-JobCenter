using System.Text.RegularExpressions;
using System.ComponentModel;
using System;

namespace Models
{
  public  class VacanciesModel : IDataErrorInfo
    {
        private FirmModel firm;
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
        public FirmModel Firm { get => firm; set => firm = value; }

        public string String { get { return GetStr(); } }
        private string GetStr()
        {
            return Sphere + " " + Experience + " " + Sallary + " " + Address + " " + Firm.String;
        }

        public VacanciesModel(FirmModel firm, string sphere, string address, bool higher_education, bool eng_knowledge, int experience, int sallary)
        {
            Firm = firm;
            Sphere = sphere;
            Address = address;
            Higher_education = higher_education;
            Eng_knowledge = eng_knowledge;
            Experience = experience;
            Sallary = sallary;
        }

        public string Error => throw new Exception(Error);     

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                      
                    case "Experience":
                        {
                            if (string.IsNullOrEmpty(this.Experience.ToString()))
                            {
                                return "Enter experience in sphere!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Za-z]*$");
                                if (regex.IsMatch(this.Experience.ToString()))
                                {
                                    return "Enter only number!";
                                }
                                else if (this.Experience > 70)
                                {
                                    return "This number too large > 70";
                                }
                                break;
                            }
                        }
                    case "Sphere":
                        {
                            if (string.IsNullOrEmpty(this.Sphere))
                            {
                                return "Enter Sphere!";
                            }
                            else if (!((this.Sphere != "IT" || this.Sphere != "Design") || (this.Sphere != "Marketing" || this.Sphere != "Management")))
                            {
                                return "Enter correct Sphere  ex. IT/Design/Marketing/Management";
                            }
                            break;
                        }
                    case "Sallary":
                        {
                            if (string.IsNullOrEmpty(this.Sallary.ToString()))
                            {
                                return "Enter sallary!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Za-z]*$");
                                if (regex.IsMatch(this.Sallary.ToString()))
                                {
                                    return "Enter only number!";
                                }
                                break;
                            }
                        }
                    case "Address":
                        {
                            Regex regex = new Regex(@"^[A-Za-z]*$");
                            if (string.IsNullOrEmpty(this.Address))
                            {
                                return "Enter Address!";
                            }
                            if (!regex.IsMatch(this.Address))
                            {
                                return "Enter adress(city)!  ex. Zhitomir";
                            }
                            break;
                        }
                    default:
                        break;
                }
                return "";
            }
        }    
    }
}
