using Microsoft.AspNetCore.Mvc;

namespace Crm.UILayer.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
