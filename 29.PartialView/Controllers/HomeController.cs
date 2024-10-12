using _29.PartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _29.PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="Something",Description="Description 1",Price=1000,Image="~/images/1.jpg"},
                new Product { Id = 2,Name="Something2",Description="Description 2",Price=2000,Image="~/images/2.png"},
            };
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
