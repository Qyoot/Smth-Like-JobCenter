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
    public class ResumeService : IResumeService
    {
        // Serialization and Deserialization function calling
        public void Save(string path, List<Resume> _list)
        {
            try
            {
                SerializationJSON<ResumeEntity> serializationJSON = new SerializationJSON<ResumeEntity>();
                serializationJSON.ToSerialize(_list.ToEntityCollection(), path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Resume> ToDeserialzie(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Resume>();
            }
            try
            {
                SerializationJSON<ResumeEntity> serializationJSON = new SerializationJSON<ResumeEntity>();
                return serializationJSON.ToDeserialzie(path).ToObjectCollection();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
