using _23.Session.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace _23.Session.Controllers
{
    //It is a state management technique
    //Session state is an ASP.NET core scenario for storage of user data while the user browser a web app
    //The session data is backed by a cache and considered ephemeral data
    //Critical application data should be stored in the user database and cached in session only as a performance optimization.
    //Session are Server-side unlike cookies which are client side
    //Default expiration time is 20 mins


    //When many users access an application simultaneously,then each of these users will have a different session state.
    //Every session has a unique session id.


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("MyKey", "Programentor");
            TempData["SessionId"] = HttpContext.Session.Id;
            return View();
        }

        public IActionResult About()
        {
            //if (HttpContext.Session.GetString("MyKey") != null)
            //{
            //    ViewBag.Data = HttpContext.Session.GetString("MyKey").ToString();
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                HttpContext.Session.Remove("MyKey");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
