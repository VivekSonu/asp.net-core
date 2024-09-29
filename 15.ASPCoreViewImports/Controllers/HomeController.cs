using _15.ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace _15.ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Gender = "Female" },
            new Student { Id = 2, Name = "Bob", Gender = "Male" },
            new Student { Id = 3, Name = "Charlie", Gender = "Male" },
            new Student { Id = 4, Name = "Diana", Gender = "Female" }
        };

            return View(students);
        }  
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
