using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void insert (T t); 
        void delete (T t);  
        void update (T t);  
        List<T> GetListAll ();
        T GetByID (int id); 
    }
}
