using BusinessLogicLayer;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class PersonMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Entities)
        public static PersonEntity ToEntity (this Person person)
        {
            return new PersonEntity(person.First_Name, person.Second_Name, person.City, person.Gender);         
        }
        public static Person ToObject(this PersonEntity entity)
        {
            return new Person(entity.First_Name,entity.Second_Name,entity.City,entity.Gender);
        }
        public static List<Person> ToObjectCollection(this List<PersonEntity> entity)
        {
            List<Person> temp = new List<Person>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<PersonEntity> ToEntityCollection(this List<Person> entity)
        {
            List<PersonEntity> temp = new List<PersonEntity>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToEntity());
            }
            return temp;
        }
    }
}
