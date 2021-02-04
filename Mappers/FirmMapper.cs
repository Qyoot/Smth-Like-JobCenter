using BusinessLogicLayer;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class FirmMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Entities)
        public static FirmEntity ToEntity(this Firm firm)
        {
            return new FirmEntity(firm.Name,firm.Sphere,firm.Quantity_of_employee,firm.Market_experience);
        }
        public static List<Firm> ToObjectCollection(this List<FirmEntity> entity)
        {
            List<Firm> temp = new List<Firm>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<FirmEntity> ToEntityCollection(this List<Firm> entity)
        {
            List<FirmEntity> temp = new List<FirmEntity>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToEntity());
            }
            return temp;
        }
        public static Firm ToObject(this FirmEntity entity)
        {
            return new Firm(entity.Name, entity.Sphere, entity.Quantity_of_employee, entity.Market_experience);
        }
    }
}
