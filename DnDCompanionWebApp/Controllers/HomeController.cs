using DnDCompanionWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDCompanionWebApp.Controllers
{
    public class HomeController : Controller
    {
        //Home controller index displays the login page
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Description = "DnD Companion Application Home Page";
            return View();
        }
        //Returns view results dependent on user's login selection
        [HttpPost]
        public IActionResult Index(LoginModel loginResult)
        {
            return View(loginResult);
        }
        public IActionResult Characters()
        {
            return Content("Home controller, Characters action");
        }
        public IActionResult DiceRoll()
        {
            return Content("Home controller, Diceroll action");
        }
    }
}
