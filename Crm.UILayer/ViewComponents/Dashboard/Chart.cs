﻿using Crm.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

namespace Crm.UILayer.Views.Dashboard
{
    public class Chart:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {           
            
                ViewBag.p1 = context.Products.Where(x => x.ProductID == 1).Select(y => y.ProductStock).FirstOrDefault();
                ViewBag.p2 = context.Products.Where(x => x.ProductID == 2).Select(y => y.ProductStock).FirstOrDefault();
                ViewBag.p3 = context.Products.Where(x => x.ProductID == 3).Select(y => y.ProductStock).FirstOrDefault();
                ViewBag.p4 = context.Products.Where(x => x.ProductID == 6).Select(y => y.ProductStock).FirstOrDefault();
            return View();
            
        }
    }
}
