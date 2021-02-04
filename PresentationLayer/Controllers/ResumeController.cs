using Services;
using Services.Abstract;
using System.Collections.Generic;
using Models;
using ModelMappers;

namespace PresentationLayer.Controllers
{
    // Serialization and Deserialization function calling form Services
    public class ResumeController
    {
        ResumeService service = new ResumeService();
        public void Save(string path, List<ResumeModel> _list)
        {
            service.Save(path, _list.ToObjectCollection());
        }

        public List<ResumeModel> ToDeserialzie(string path)
        {
            return service.ToDeserialzie(path).ToModelCollection();
        }
    }
}
