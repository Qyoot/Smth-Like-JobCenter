using System;

namespace Entities
{
    [Serializable]
    public class FirmEntity 
    {
        private string name;
        private string sphere;
        private int quantity_of_employee;
        private int market_experience;

        public string Name { get => name; set => name = value; }
        public string Sphere { get => sphere; set => sphere = value; }
        public int Quantity_of_employee { get => quantity_of_employee; set => quantity_of_employee = value; }
        public int Market_experience { get => market_experience; set => market_experience = value; }

        public FirmEntity()
        {
            name = null;
            sphere = null;
            quantity_of_employee = 0;
            market_experience = 0;
        }

        public FirmEntity(string name, string sphere, int quantity_of_employee, int market_experience)
        {
            this.name = name;
            this.sphere = sphere;
            this.quantity_of_employee = quantity_of_employee;
            this.market_experience = market_experience;
        }

    }
}
