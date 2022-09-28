using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        
        Context context= new Context();
        DbSet<T> _object;   
        
        public GenericRepository()
        {
            _object = context.Set<T>(); 
        }

        public void delete(T t)
        {
            _object.Remove(t);  
            context.SaveChanges();  
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll()
        {
            return _object.ToList();

        }

        public void insert(T t)
        {
            _object.Add(t);
            context.SaveChanges();
        }

        public void update(T t)
        {
            _object.Update(t);
            context.SaveChanges();
        }
    }
}
