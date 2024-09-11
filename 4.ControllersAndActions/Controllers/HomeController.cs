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
        public IActionResult Index()
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
