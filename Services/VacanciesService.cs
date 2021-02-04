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
    public class VacanciesService : IVacanciesService
    {
        // Serialization and Deserialization function calling
        public void Save(string path, List<Vacancies> _list)
        {
            try
            {
                SerializationJSON<VacanciesEntity> serializationJSON = new SerializationJSON<VacanciesEntity>();
                serializationJSON.ToSerialize(_list.ToEntityCollection(), path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Vacancies> ToDeserialzie(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Vacancies>();
            }
            try
            {
                SerializationJSON<VacanciesEntity> serializationJSON = new SerializationJSON<VacanciesEntity>();
                return serializationJSON.ToDeserialzie(path).ToObjectCollection();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
