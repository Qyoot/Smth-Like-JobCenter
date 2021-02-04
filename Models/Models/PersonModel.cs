using System.Text.RegularExpressions;
using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;

namespace Models
{
    public class PersonModel : IDataErrorInfo, INotifyPropertyChanged
    {
        private string first_Name;
        private string second_Name;
        private string city;
        private string gender;
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public string First_Name { get => first_Name; 
            set 
            { 
                first_Name = value;
                OnPropertyChanged("First_Name");
            } 
        }
        public string Second_Name { get => second_Name; 
            set 
            { 
                second_Name = value;
                OnPropertyChanged("Second_Name");
            } 
        }
        public string City { get => city; 
            set 
            { 
        
                city = value;
                OnPropertyChanged("City");
            } 
        }
        public string Gender { get => gender; 
            set 
            { 
                gender = value;
                OnPropertyChanged("Gender");
            } 
        }
        
        public string String { get => GetStr(); }
        private string GetStr()
        {
            string str = " First name: " + first_Name + "\n Second Name: " + second_Name + "\n City: " + city + "\n Gender: " + gender;
            return str;
        }
        public string FullName { get => first_Name + " " + second_Name; }

        public string Error => throw new Exception(Error);

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "First_Name":
                        {
                            if (string.IsNullOrEmpty(this.First_Name))
                            {
                                return "Enter Name!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Z]{1}[a-z]*$");
                                if (!regex.IsMatch(this.First_Name))
                                {
                                    return "Enter correct name. Ex. Steve";
                                }
                                break;
                            }
                        }
                    case "Second_Name":
                        {
                            if (string.IsNullOrEmpty(this.Second_Name))
                            {
                                return "Enter Last Name!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Z]{1}[a-z]*$");
                                if (!regex.IsMatch(this.Second_Name))
                                {
                                    return "Enter correct name. Ex. Jobs";
                                }
                                break;
                            }
                        }
                    case "City":
                        {
                            if (string.IsNullOrEmpty(this.City))
                            {
                                return "Enter City!";
                            }
                            else
                            {
                                Regex regex = new Regex(@"^[A-Z]{1}[a-z]*$");
                                if (!regex.IsMatch(this.City))
                                {
                                    return "Enter correct name of city. Ex. Vinnytsia";
                                }
                                break;
                            }
                        }
                    case "Gender":
                        {
                            if (string.IsNullOrEmpty(this.Gender))
                            {
                                return "Enter Gender!";
                            }
                            else if (!((this.Gender != "Male" || this.Gender != "Female") || (this.Gender != "Male" || this.Gender != "Female")))
                            {
                                return "Enter correct Gender  ex. Female/male";
                            }
                            break;
                        }

                    default:
                        break;
                }
                return "";
            }
        }

        enum GenderEnum
        {
            Male, Female, male, female
        }
        public PersonModel(string first_Name, string second_Name, string city, string gender)
        {
            First_Name = first_Name;
            Second_Name = second_Name;
            City = city;
            Gender = gender;
            
        }
        public PersonModel()
        {
            first_Name = null;
            second_Name = null;
            city = null;
            gender = null;
           
        }
    }
}
