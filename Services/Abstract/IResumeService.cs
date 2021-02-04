using BusinessLogicLayer;
using System.Collections.Generic;

namespace Services.Abstract
{
   public interface IResumeService
    {
        public void Save(string path, List<Resume> _list);
        public List<Resume> ToDeserialzie(string path);
    }
}
