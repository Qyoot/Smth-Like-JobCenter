using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Serialization
{
    public class SerializationJSON<T> : ISerializationProvider<T>
    {
        public void ToSerialize(List<T> obj, string path)
        {
            try
            {
                File.Delete(path);
                string json = JsonSerializer.Serialize<List<T>>(obj);
                File.WriteAllText(path, json);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<T> ToDeserialzie(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                List<T> entityArray = JsonSerializer.Deserialize<List<T>>(json);
                return entityArray;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}

