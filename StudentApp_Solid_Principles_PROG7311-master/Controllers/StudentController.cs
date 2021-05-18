using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentWebAppMVC.Models;

namespace StudentWebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            StudentModel sModel = new StudentModel();
            return View(sModel);
        }

        
        [HttpPost]  
        public ActionResult Create(StudentModel model)  
        {  
            ViewBag.Output = "Hello user, the matrix has summoned you," + model.Name.ToString() + ". To carry on studying " + model.Course.ToString();
            return View();  
        }  


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}