using BusinessLogicLayer;
using Models;
using System.Collections.Generic;

namespace ModelMappers
{
   public static class PersonModelMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Models)
        public static PersonModel ToModel(this Person person)
        {
            return new PersonModel(person.First_Name, person.Second_Name, person.City, person.Gender);
        }

        public static Person ToObject(this PersonModel entity)
        {
            return new Person(entity.First_Name, entity.Second_Name, entity.City, entity.Gender);
        }

        public static List<Person> ToObjectCollection(this List<PersonModel> entity)
        {
            List<Person> temp = new List<Person>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }

        public static List<PersonModel> ToModelCollection(this List<Person> entity)
        {
            List<PersonModel> temp = new List<PersonModel>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToModel());
            }
            return temp;
        }
    }
}
