using BusinessLogicLayer;
using System.Collections.Generic;

namespace Services.Abstract
{
   public interface IFirmService
    {
       public void Save(string path, List<Firm> _list);
       public List<Firm> ToDeserialzie(string path);
    }
}
