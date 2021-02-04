using BusinessLogicLayer;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class VacanciesMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Entities)
        public static VacanciesEntity ToEntity(this Vacancies vacancies)
        {
            return new VacanciesEntity(vacancies.Firm.ToEntity(),vacancies.Sphere,vacancies.Address,vacancies.Higher_education
                                                                ,vacancies.Eng_knowledge,vacancies.Experience,vacancies.Sallary);
        }

        public static Vacancies ToObject(this VacanciesEntity entity)
        {
            return new Vacancies(entity.Firm.ToObject(), entity.Sphere, entity.Address, entity.Higher_education
                                                                ,entity.Eng_knowledge, entity.Experience, entity.Sallary);
        }
        public static List<Vacancies> ToObjectCollection(this List<VacanciesEntity> entity)
        {
            List<Vacancies> temp = new List<Vacancies>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<VacanciesEntity> ToEntityCollection(this List<Vacancies> entity)
        {
            List<VacanciesEntity> temp = new List<VacanciesEntity>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToEntity());
            }
            return temp;
        }
    }
}
