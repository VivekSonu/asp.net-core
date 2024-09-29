﻿using _10.ModelsInASPCore.Models;
using _10.ModelsInASPCore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _10.ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository=null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getById (int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{ 
            //  new StudentModel {rollNo = 1,Name="Kumar",Standard=11,Gender="Male"},
            //  new StudentModel {rollNo = 2,Name="Vivek",Standard=11,Gender="Male"},
            //  new StudentModel {rollNo = 3,Name="Singh",Standard=11,Gender="Male"},
            //};

            //ViewData["myStudents"]=students;
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
