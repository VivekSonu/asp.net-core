using Microsoft.AspNetCore.Mvc;

namespace AreasDemoASPCore.Areas.Blogs.Controllers
{
    [Area("Blogs")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
