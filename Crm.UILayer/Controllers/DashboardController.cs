using Microsoft.AspNetCore.Mvc;

namespace Crm.UILayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
