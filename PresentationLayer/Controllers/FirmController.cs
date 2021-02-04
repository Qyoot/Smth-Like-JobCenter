using Services;
using System.Collections.Generic;
using Models;
using ModelMappers;

namespace PresentationLayer.Controllers
{
    // Serialization and Deserialization function calling form Services
    public class FirmController
    {
        FirmService service = new FirmService();
        public void Save(string path, List<FirmModel> _list)
        {
            service.Save(path, _list.ToObjectCollection());
        }

        public List<FirmModel> ToDeserialzie(string path)
        {
            return service.ToDeserialzie(path).ToModelCollection();
        }
    }
}
