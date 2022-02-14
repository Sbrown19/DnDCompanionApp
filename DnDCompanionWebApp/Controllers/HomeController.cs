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
            ViewBag.Title = "Characters";
            ViewBag.Description = "DnD Characters Page";
            return View();
        }
        public IActionResult DiceRoll()
        {
            ViewBag.Title = "DiceRoll";
            ViewBag.Description = "DnD Dice Roll Page";
            return View();
        }
    }
}
