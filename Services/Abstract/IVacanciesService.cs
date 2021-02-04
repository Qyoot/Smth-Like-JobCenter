using BusinessLogicLayer;
using System.Collections.Generic;

namespace Services.Abstract
{
   public interface IVacanciesService
    {
        public void Save(string path, List<Vacancies> _list);
        public List<Vacancies> ToDeserialzie(string path);
    }
}
