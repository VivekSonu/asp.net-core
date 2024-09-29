using Microsoft.AspNetCore.Mvc;

namespace _1.ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        //Note:Rules for creating action method
        //     it should be public
        //     it should not be static 
        //All the methods inside a controller which responds to url are known as Action Methods.
        
        //IActionResult and ActionResult work as a container for the other action results.
        //IActionResult is an interface and ActionResult is an abstract class that other action results inherit from
        
        
        //You can use the following objects to pass data between controller and view:
        //1.ViewData
        //2.ViewBag
        //3.TempData
        //4.StronglyTypedViews
        
        
        public IActionResult Index()
        {
            ViewBag.data1 = "Vivek";
            ViewBag.data2 = 24;
            ViewBag.data3=DateTime.Now.ToShortDateString();

            string[] arr = { "Vivek", "Kumar", "Singh" };
            ViewBag.data4 = arr;

            ViewBag.data5= new List<String>() { "Cricket", "Football", "Hockey" };

            ViewData["myName"] = "Viv";

            //ViewData["data1"] = "Vivek";
            //ViewData["data2"] = 23;
            //ViewData["data3"] = DateTime.Now.ToLongDateString();

            //string[] arr = { "Vivek", "Kumar", "Singh" };
            //ViewData["data4"]=arr;

            //ViewData["data5"]=new List<String>() {"Cricket","Football","Hockey"};

            return View(); //ViewResult, PartialViewResult,JasonResult implements IActionResult
        }
        public IActionResult About()
        {
            return View(); //ViewResult, PartialViewResult,JasonResult implements IActionResult
        }
        public IActionResult Contact()
        {
            return View(); //ViewResult, PartialViewResult,JasonResult implements IActionResult
        }
        public string Display()
        {
            return "Welcome"; 
        }
        public int DisplayId(int id)
        {
            return id; 
        }
    }
}
