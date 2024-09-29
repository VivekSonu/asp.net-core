using _16.TagHelpersDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _16.TagHelpersDemo.Controllers
{

    //ModelBinding:Model Binding in ASP.net core MVC maps data from HTTP requests to action method parameters 
    //ModelValidator:ASP.net core gives us Model Validator,which uses the validation attributes to validate the model,which makes our task easier.
    //ModelState:We also take a look at ModelState and how to use it.Finally,we lool at the list of Validation attributes.
    //The form Data is posted to Controller action is automatically mapped to the action parameter by the model Binder. 
    //The model needs to be validated for the correctness.
    //The validations can be done at the client side before sending data to server or at the server side when the data is received from the client.
    //Explicitly Validating a Model:
    //Once you received the model in the controller,you can validate the model programmatiaclly 
    //When the HTTP Request arrives Model binder is invoked before passing the control to contoller action method
    //The Model binder not only binds the value to the action parameter but also validates them by using the Model Validator.
    //Built-in attributes
    //[Required]
    //[StringLength]
    //[EmailAddress]
    //[Range]
    //[RegularExpression]
    //[Compare]
    //[Phone]
    //[url]
    //All these validation attributes are located in System.ComponentModel.DataAnnotations;
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

        //[HttpPost]
        //public string Index(Employee e)
        //{
        //    return "Name: " + e.Name + " Gender: " + e.Gender + " Age: " + e.Age + "Designation: " + e.Designation + "Salary: " + e.Salary + " Married: " + e.Married + "Description: " + e.Description;
        //}
        [HttpPost]
        //public string Index(Student std)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        return "Name is: " + std.Name;
        //    }
        //    else
        //    {
        //        return "Validation Failed..";
        //    }
        //}
        public IActionResult Index(Student std)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
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
