using _16.TagHelpersDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _16.TagHelpersDemo.Controllers
{

    //ModelBinding:Model Binding in ASP.net core MVC maps data from HTTP requests to action method parameters 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Employee e)
        {
            return "Name: " + e.Name + " Gender: " + e.Gender + " Age: " + e.Age + "Designation: " + e.Designation + "Salary: " + e.Salary + " Married: " + e.Married + "Description: " + e.Description;
        }
        public string Details(int id ,string name)
        {
            return "ID is:"+id+" Name is:"+name;
        }
        public IActionResult Contact()
        {
            return View();
        }
        public int Edit(int id)
        {
            return id;
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
