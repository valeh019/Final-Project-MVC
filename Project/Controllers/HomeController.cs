using Microsoft.AspNetCore.Mvc;

namespace vbankASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
