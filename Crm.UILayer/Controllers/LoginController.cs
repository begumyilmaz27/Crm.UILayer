using Microsoft.AspNetCore.Mvc;

namespace Crm.UILayer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
