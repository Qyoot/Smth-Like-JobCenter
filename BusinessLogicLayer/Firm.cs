namespace BusinessLogicLayer
{
    public class Firm 
    {
        private string name;
        private string sphere;
        private int quantity_of_employee;
        private int market_experience;    

        public string Name { get => name; set => name = value; }
        public string Sphere { get => sphere; set => sphere = value; }
        public int Quantity_of_employee { get => quantity_of_employee; set => quantity_of_employee = value; }
        public int Market_experience { get => market_experience; set => market_experience = value; }


        public Firm(string name, string sphere, int quantity_of_employee, int market_experience)
        {
            Name = name;
            Sphere = sphere;
            Quantity_of_employee = quantity_of_employee;
            Market_experience = market_experience;
        }

        public Firm()
        {
            name = null;
            sphere = null;
            quantity_of_employee = 0;
            market_experience = 0;
        }
    }
}
