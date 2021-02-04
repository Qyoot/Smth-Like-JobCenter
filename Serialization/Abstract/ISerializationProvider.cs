
using System.Collections.Generic;

namespace Serialization
{
   public interface ISerializationProvider<T>
    {
        public void ToSerialize(List<T> obj, string path);
        public List<T> ToDeserialzie(string path);
    }
}
