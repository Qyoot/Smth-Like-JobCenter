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
    public class FirmService : IFirmService
    {
        // Serialization and Deserialization function calling
        public void Save(string path, List<Firm> _list)
        {
            try
            {
                SerializationJSON<FirmEntity> serializationJSON = new SerializationJSON<FirmEntity>();
                serializationJSON.ToSerialize(_list.ToEntityCollection(), path);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Firm> ToDeserialzie(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Firm>();
            }
            try
            {
                SerializationJSON<FirmEntity> serializationJSON = new SerializationJSON<FirmEntity>();
                return serializationJSON.ToDeserialzie(path).ToObjectCollection();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
