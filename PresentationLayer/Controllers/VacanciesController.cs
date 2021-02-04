using Services;
using System.Collections.Generic;
using Models;
using ModelMappers;

namespace PresentationLayer.Controllers
{
    // Serialization and Deserialization function calling form Services
    public class VacanciesController
    {
        VacanciesService service = new VacanciesService();
        public void Save(string path, List<VacanciesModel> _list)
        {
            service.Save(path, _list.ToObjectCollection());
        }

        public List<VacanciesModel> ToDeserialzie(string path)
        {
            return service.ToDeserialzie(path).ToModelCollection();
        }
    }
}
