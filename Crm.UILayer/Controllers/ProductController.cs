using Crm.BusinessLayer.Concrete;
using Crm.DataAccessLayer.EntityFrameWork;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Crm.UILayer.Controllers
{
    public class ProductController : Controller
    {

        ProductManager productManager = new ProductManager(new EfProductDal());

        public IActionResult Index()
        {
            var values = productManager.TGetListProductWithCategory();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productManager.TInsert(product);
            return RedirectToAction("Index");
        }
    }
}

