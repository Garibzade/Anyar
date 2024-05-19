using Microsoft.AspNetCore.Mvc;

namespace Anyar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
