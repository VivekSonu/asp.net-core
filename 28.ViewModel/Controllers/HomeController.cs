using _28.ViewModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _28.ViewModel.Controllers
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
            List<Student> students = new List<Student>()
            { 
                new Student{Id=1, Name="Vivek",Gender="Male",Standard=12},        
                new Student{Id=2, Name="Kumar",Gender="Male",Standard=12},        
                new Student{Id=3, Name="Singh",Gender="Male",Standard=12},        
            };
            List<Teacher> teachers = new List<Teacher>()
            { 
                new Teacher{Id=1, Name="Sir Vivek",Qualification="MCA",Salary=45999},        
                new Teacher{Id=2, Name="Sir Kumar",Qualification="BSC",Salary=45999},        
                new Teacher{Id=3, Name="Sir Singh",Qualification="HighSchool",Salary=45999},        
            };

            SchoolViewModel svm=new SchoolViewModel()
            {
                myStudents = students,
                myTeachers = teachers
            };

            return View(svm);
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
