using System.Text.RegularExpressions;
using System.ComponentModel;
using System;

namespace Models
{
    public class FirmModel : IDataErrorInfo
    {
        private string name;
        private string sphere;
        private int quantity_of_employee;
        private int market_experience;

        public string Name { get => name; set => name = value; }
        public string Sphere { get => sphere; set => sphere = value; }
        public int Quantity_of_employee { get => quantity_of_employee; set => quantity_of_employee = value; }
        public int Market_experience { get => market_experience; set => market_experience = value; }

        public string String { get { return GetStr(); } }
        private string GetStr()
        {
            return "Name: "+ Name + "\nSphere: " + Sphere + "\nQuantity of employee: " + Quantity_of_employee + "\nMarket experience: " + Market_experience;
        }
        public string Error => throw new Exception(Error);

        public string this[string columnName]
        {

            get
            {
                switch (columnName)
                {
                    case "Name":
                        {
                            if (string.IsNullOrEmpty(this.Name))
                            {
                                return "Enter Name!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Z]{1}[a-z]*$");
                                if (!regex.IsMatch(this.Name))
                                {
                                    return "Enter correct name. Ex. Company";
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
                    case "Quantity_of_employee":
                        {
                            Regex regex = new Regex(@"^[A-Za-z]*$");
                            if (regex.IsMatch(this.Quantity_of_employee.ToString()))
                            {
                                return "Enter only number!";
                            }
                            break;
                        }
                    case "Market_experience":
                        {
                            Regex regex = new Regex(@"^[A-Za-z]*$");
                            if (regex.IsMatch(this.Market_experience.ToString()))
                            {
                                return "Enter only number!";
                            }
                            break;
                        }
                    default:
                        break;
                }
                return "";
            }
        }

        public FirmModel(string name, string sphere, int quantity_of_employee, int market_experience)
        {
            Name = name;
            Sphere = sphere;
            Quantity_of_employee = quantity_of_employee;
            Market_experience = market_experience;
        }

        public FirmModel()
        {
            Name = null;
            Sphere = null;
            Quantity_of_employee = 0;
            Market_experience = 0;
        }
    }
}
