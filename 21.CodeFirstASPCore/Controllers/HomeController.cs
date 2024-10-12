using _20.CodeFirstASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _20.CodeFirstASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext studentDB;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(StudentDBContext studentDB)
        {
            this.studentDB = studentDB;
        }

        public async Task<IActionResult> Index()
        {
            var stdData=await studentDB.Students.ToListAsync();
            return View(stdData);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if(id== null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stdData=await studentDB.Students.FirstOrDefaultAsync(x=>x.Id==id);
            return View(stdData);
        }
        public IActionResult Create()
        {
            List<SelectListItem> Gender = new()
            {
                new SelectListItem{Value="Male",Text="Male"},
                new SelectListItem{Value="Female",Text="Female"},
            };
            ViewBag.Gender = Gender;    
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student std)
        {
            if(ModelState.IsValid)
            {
                await studentDB.Students.AddAsync(std);
                await studentDB.SaveChangesAsync();
                TempData["insert_success"] = "Inserted..";
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null || studentDB.Students == null) { return NotFound(); }   

            var stdData = await studentDB.Students.FindAsync(id);
            if(stdData==null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Student std)
        {
            if(id!=std.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                studentDB.Students.Update(std);
                await studentDB.SaveChangesAsync();
                TempData["update_success"] = "Updated..";
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }
         
        public async Task<IActionResult> Delete(int?id)
        {
            if (id == null || studentDB.Students == null) { return NotFound(); }
            var stdData = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int?id)
        {
            var stdData = await studentDB.Students.FindAsync(id);
            if (stdData != null)
            {
                studentDB.Students.Remove(stdData);
            }
            await studentDB.SaveChangesAsync();
            TempData["delete_success"] = "Deleted..";
            return RedirectToAction("Index", "Home");
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
