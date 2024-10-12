using CRUDAppUsingASPCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CRUDAppUsingASPCoreWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:7067/api/StudentAPI/";
        private HttpClient client=new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response=client.GetAsync(url).Result;
            if(response.IsSuccessStatusCode)
            {
                string result=response.Content.ReadAsStringAsync().Result;
                var data=JsonConvert.DeserializeObject<List<Student>>(result);
                if(data!=null)
                {
                    students=data;
                }
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Create(Student std)
        {
            string data=JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response=client.PostAsync(url, content).Result;
            if(response.IsSuccessStatusCode)
            {
                TempData["insert_message"] = "Student Added..";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url+id).Result;
            if(response.IsSuccessStatusCode)
            {
                string result= response.Content.ReadAsStringAsync().Result;
                var data= JsonConvert.DeserializeObject<Student>(result);
                if(data!=null)
                {
                    std=data;
                }
            }
            return View(std);
        }
        
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            string data=JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url+std.id,content).Result;
            if(response.IsSuccessStatusCode)
            {
                TempData["update_message"] = "Student Updated..";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    std = data;
                }
            }
            return View(std);
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    std = data;
                }
            }
            return View(std);
        }
        
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            HttpResponseMessage response = client.DeleteAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["delete_message"] = "Student Deleted..";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
    

    
}
//The line StringContent content = new StringContent(data, Encoding.UTF8, "application/json"); creates an instance of the StringContent class, which is used to send string data in an HTTP request. Here’s a breakdown of what each part does:

//data: This is the JSON string that you created from the Student object using JsonConvert.SerializeObject(std);.
//Encoding.UTF8: This specifies that the string data should be encoded using UTF-8.UTF - 8 is a standard encoding that ensures the data is correctly interpreted by the server, especially if it contains special characters.
//"application/json": This sets the content type of the HTTP request to application/json. This tells the server that the data being sent is in JSON format, which is important for the server to correctly parse and process the data.
//Putting it all together, this line of code creates a StringContent object that contains your JSON data, encoded in UTF-8, and specifies that the content type is JSON. This StringContent object can then be used in an HTTP request to send the JSON data to a server.