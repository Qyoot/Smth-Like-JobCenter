using System.Text.RegularExpressions;
using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Models
{
    public class ResumeModel : IDataErrorInfo 
    {
        private PersonModel person;
        private bool higher_education;
        private bool eng_knowledge;
        private int experience;
        private string about_person;
        private string sphere; 
        private int expected_sallary; 
        

        public ResumeModel(PersonModel person, bool higher_education, bool eng_knowledge, int experience, string about_person, string sphere, int expected_sallary)
        {
            this.person = person;
            this.higher_education = higher_education;
            this.eng_knowledge = eng_knowledge;
            this.experience = experience;
            this.about_person = about_person;
            this.sphere = sphere;
            this.expected_sallary = expected_sallary;
        }

        public string Error => throw new Exception(Error);

        public bool Higher_education { get => higher_education; set => higher_education = value; }
        public bool Eng_knowledge { get => eng_knowledge; set => eng_knowledge = value; }
        public int Experience { get => experience; set => experience = value; }
        public string About_person { get => about_person; set => about_person = value; }
        public string Sphere { get => sphere; set => sphere = value; }
        public int Expected_sallary { get => expected_sallary; set => expected_sallary = value; }
        public string String { get { return GetStr(); } }

        public PersonModel Person { get => person; set => person = value; }

        private string GetStr()
        {
            string str = person.ToString() + " " + Experience + " " + Sphere + " " + Expected_sallary +" "+Person.String;
            return str;
        }

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
                                else if(this.Experience > 60)
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
                            else if (!((this.Sphere == "IT" || this.Sphere == "Design") || (this.Sphere == "Marketing" || this.Sphere == "Management")))
                            {
                                return "Enter correct Sphere  ex. IT/Design/Marketing/Management";
                            }
                            break;
                        }
                    case "Expected_sallary":
                        {
                            if (string.IsNullOrEmpty(this.Expected_sallary.ToString()))
                            {
                                return "Enter expected sallary!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Za-z]*$");
                                if (regex.IsMatch(this.Expected_sallary.ToString()))
                                {
                                    return "Enter only number!";
                                }
                                break;
                            }
                        }
                }
                return "";
            }          
        }
    }
}
