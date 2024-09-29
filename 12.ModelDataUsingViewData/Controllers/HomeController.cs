using _12.ModelDataUsingViewData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _12.ModelDataUsingViewData.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId=101,
            //    EmpName="Vivek",
            //    Designation="Manager",
            //    Salary=25000
            //};

            var myEmployees=new List<Employee>();
            {
                new Employee { EmpId = 101, EmpName = "Vivek", Designation = "Manager", Salary = 40000 };
                new Employee { EmpId = 102, EmpName = "Vivek", Designation = "Manager", Salary = 40000 };
                new Employee { EmpId = 103, EmpName = "Vivek", Designation = "Manager", Salary = 40000 };
                new Employee { EmpId = 104, EmpName = "Vivek", Designation = "Manager", Salary = 40000 };
                new Employee { EmpId = 105, EmpName = "Vivek", Designation = "Manager", Salary = 40000 };
            };

            ViewData["myEmployee"] = myEmployees;

            //ViewData["myEmployee"]=emp;
            //ViewBag.myEmployee=emp;
            return View();
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
