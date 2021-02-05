using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace Models
{
   public class CategoryModel : IDataErrorInfo
    {
        private string name;
        private List<ResumeModel> resume;
        private List<VacanciesModel> vacancies;

        public string Name { get => name; set => name = value; }

        public string Error => throw new NotImplementedException();

        public string this[string columnName] => throw new NotImplementedException();

        public CategoryModel(string name, List<ResumeModel> resume, List<VacanciesModel> vacancies)
        {
            this.name = name;
            this.resume = resume;
            this.vacancies = vacancies;
        }

        public CategoryModel()
        {
            name = null;
            resume = null;
            vacancies = null;
        }
    }
}
