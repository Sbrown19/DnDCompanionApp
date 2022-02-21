using Microsoft.AspNetCore.Mvc;

namespace DnDCompanionWebApp.Controllers
{
    public class Module6AssignmentController : Controller
    {
        [HttpGet]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult Students()
        {
            ViewBag.Title = "Students";
            ViewBag.Description = "Assignment 6.1 Home Page";
            return View();
        }
    }
}
