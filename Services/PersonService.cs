using BusinessLogicLayer;
using Services.Abstract;
using Serialization;
using Entities;
using System.Collections.Generic;
using System;
using Mappers;
using System.IO;

namespace Services
{
    public class PersonService : IPersonService
    {
        // Serialization and Deserialization function calling
        public void Save(string path, List<Person> _list)
        {
            try
            {
                SerializationJSON<PersonEntity> serializationJSON = new SerializationJSON<PersonEntity>();
                serializationJSON.ToSerialize(_list.ToEntityCollection(), path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Person> ToDeserialzie(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Person>();
            }
            try
            {
                SerializationJSON<PersonEntity> serializationJSON = new SerializationJSON<PersonEntity>();
                return serializationJSON.ToDeserialzie(path).ToObjectCollection();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
