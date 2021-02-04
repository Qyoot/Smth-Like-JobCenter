using System;

namespace Entities
{
    [Serializable]
    public class PersonEntity 
    {
        private string first_Name;
        private string second_Name;
        private string city;
        private string gender;

        public string First_Name { get => first_Name; set => first_Name = value; }
        public string Second_Name { get => second_Name; set => second_Name = value; }
        public string City { get => city; set => city = value; }
        public string Gender { get => gender; set => gender = value; }

        public PersonEntity()
        {
            first_Name = null;
            second_Name = null;
            city = null;
            gender = null;

        }

        public PersonEntity(string first_Name, string second_Name, string city, string gender)
        {
            this.first_Name = first_Name;
            this.second_Name = second_Name;
            this.city = city;
            this.gender = gender;

        }


    }
}
