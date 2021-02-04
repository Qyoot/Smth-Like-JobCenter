using BusinessLogicLayer;
using Models;
using System.Collections.Generic;

namespace ModelMappers
{
   public static class FirmModelMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Model)
        public static Firm ToObject(this FirmModel entity)
        {
            return new Firm(entity.Name, entity.Sphere, entity.Quantity_of_employee, entity.Market_experience);
        }
        public static FirmModel ToModel(this Firm entity)
        {
            return new FirmModel(entity.Name, entity.Sphere, entity.Quantity_of_employee, entity.Market_experience);
        }
        public static List<Firm> ToObjectCollection(this List<FirmModel> entity)
        {
            List<Firm> temp = new List<Firm>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<FirmModel> ToModelCollection(this List<Firm> entity)
        {
            List<FirmModel> temp = new List<FirmModel>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToModel());
            }
            return temp;
        }
    }
}
