using BusinessLogicLayer;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class ResumeMapper
    {
        //Mappers were made in order to send data from layer to layer and interract with DataAccessLayer (Entities)
        public static ResumeEntity ToEntity(this Resume resume)
        {
            return new ResumeEntity(resume.Person.ToEntity(),resume.Higher_education,resume.Eng_knowledge,resume.Experience,resume.About_person,resume.Sphere,resume.Expected_sallary);
        }
        public static Resume ToObject(this ResumeEntity entity)
        {
            return new Resume(entity.Person.ToObject(), entity.Higher_education, entity.Eng_knowledge, entity.Experience, entity.About_person,entity.Sphere,entity.Expected_sallary);
        }
        public static List<Resume> ToObjectCollection(this List<ResumeEntity> entity)
        {
            List<Resume> temp = new List<Resume>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToObject());
            }
            return temp;
        }
        public static List<ResumeEntity> ToEntityCollection(this List<Resume> entity)
        {
            List<ResumeEntity> temp = new List<ResumeEntity>();
            foreach (var ent in entity)
            {
                temp.Add(ent.ToEntity());
            }
            return temp;
        }

    }
}
