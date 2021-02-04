using BusinessLogicLayer;
using System.Collections.Generic;

namespace Services.Abstract
{
   public interface IPersonService
    {
        public void Save(string path, List<Person> _list);
        public List<Person> ToDeserialzie(string path);
    }
}
