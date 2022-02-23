using Microsoft.AspNetCore.Mvc;
using DnDCompanionWebApp.Models;

namespace DnDCompanionWebApp.Controllers
{
    public class Module6AssignmentController : Controller
    {
        private StudentViewModel stv { get; set; }

        public Module6AssignmentController(StudentViewModel acc)
        {
            stv = acc;
        }
        [HttpGet]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult StudentsView()//for the love of god dont change this
        {
            ViewBag.Title = "Students";
            ViewBag.Description = "Assignment 6.1 Home Page";
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int AccIn)
        {
            ViewBag.Action = "Edit"
            stv.AccParam = AccIn;
            return View();
        }
    
    }
}
