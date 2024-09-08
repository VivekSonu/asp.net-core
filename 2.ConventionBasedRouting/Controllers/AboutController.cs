using Microsoft.AspNetCore.Mvc;

namespace _2.ConventionBasedRouting.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
