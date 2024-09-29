using Microsoft.AspNetCore.Mvc;

namespace _14.InstallingBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
