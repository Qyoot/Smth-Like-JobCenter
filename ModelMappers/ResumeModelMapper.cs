using BusinessLogicLayer;
using Models;
using System.Collections.Generic;

namespace ModelMappers
{
   public static class ResumeModelMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Models)
        public static ResumeModel ToModel(this Resume resume)
        {
            return new ResumeModel(resume.Person.ToModel(), resume.Higher_education, resume.Eng_knowledge, resume.Experience, resume.About_person, resume.Sphere, resume.Expected_sallary);
        }
        public static Resume ToObject(this ResumeModel entity)
        {
            return new Resume(entity.Person.ToObject(), entity.Higher_education, entity.Eng_knowledge, entity.Experience, entity.About_person, entity.Sphere, entity.Expected_sallary);
        }
        public static List<Resume> ToObjectCollection(this List<ResumeModel> entity)
        {
            List<Resume> temp = new List<Resume>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<ResumeModel> ToModelCollection(this List<Resume> entity)
        {
            List<ResumeModel> temp = new List<ResumeModel>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToModel());
            }
            return temp;
        }
    }
}
