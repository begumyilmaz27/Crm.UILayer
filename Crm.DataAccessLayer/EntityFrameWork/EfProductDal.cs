using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.Concrete;
using Crm.DataAccessLayer.Repository;
using Crm.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.DataAccessLayer.EntityFrameWork
{
    
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
        Context Context=new Context();
        public List<Product> GetListProductWithCategory()
        {
            return Context.Products.Include(x=> x.category).ToList();   
        }
    }
}
