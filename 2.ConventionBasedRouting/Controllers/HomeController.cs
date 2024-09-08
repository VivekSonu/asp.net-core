using Microsoft.AspNetCore.Mvc;

namespace _2.ConventionBasedRouting.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Data()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Home/Details/{id?}")]
        public int Details(int? id)
        {
            return id??1;
        }
    }
}
