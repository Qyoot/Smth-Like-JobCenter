using BusinessLogicLayer;
using Models;
using System.Collections.Generic;

namespace ModelMappers
{
   public static class VacanciesModelMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Models)
        public static Vacancies ToObject(this VacanciesModel vacancies)
        {
            return new Vacancies(vacancies.Firm.ToObject(), vacancies.Sphere, vacancies.Address, vacancies.Higher_education
                                                                , vacancies.Eng_knowledge, vacancies.Experience, vacancies.Sallary);
        }

        public static VacanciesModel ToModel(this Vacancies entity)
        {
            return new VacanciesModel(entity.Firm.ToModel(), entity.Sphere, entity.Address, entity.Higher_education
                                                                , entity.Eng_knowledge, entity.Experience, entity.Sallary);
        }
        public static List<Vacancies> ToObjectCollection(this List<VacanciesModel> entity)
        {
            List<Vacancies> temp = new List<Vacancies>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<VacanciesModel> ToModelCollection(this List<Vacancies> entity)
        {
            List<VacanciesModel> temp = new List<VacanciesModel>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToModel());
            }
            return temp;
        }
    }
}
