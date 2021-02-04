namespace BusinessLogicLayer
{
    public class Person 
    {
        private string first_Name;
        private string second_Name;
        private string city;
        private string gender;
 
        public string First_Name { get => first_Name; set => first_Name = value; }
        public string Second_Name { get => second_Name; set => second_Name = value; }
        public string City { get => city; set => city = value; }
        public string Gender { get => gender; set => gender = value; }

      
        public Person(string first_Name, string second_Name, string city, string gender)
        {
            First_Name = first_Name;
            Second_Name = second_Name;
            City = city;
            Gender = gender;

        }
        public Person()
        {
            first_Name = null;
            second_Name = null;
            city = null;
            gender = null;

        }
    }
}
