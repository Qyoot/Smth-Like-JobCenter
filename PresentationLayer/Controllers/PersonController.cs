using Services;
using Services.Abstract;
using System.Collections.Generic;
using Models;
using ModelMappers;

namespace PresentationLayer.Controllers
{
    // Serialization and Deserialization function calling form Services
    public class PersonController
    {
        PersonService service = new PersonService();
        public void Save(string path, List<PersonModel> _list)
        {
            service.Save(path, _list.ToObjectCollection());
        }

        public List<PersonModel> ToDeserialzie(string path)
        {
            return service.ToDeserialzie(path).ToModelCollection();
        }
    }
}
