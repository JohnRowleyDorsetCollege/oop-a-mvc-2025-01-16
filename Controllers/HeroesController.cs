using Microsoft.AspNetCore.Mvc;

namespace oop_mvc_1.Controllers
{
    public class HeroesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DC()
        {
            ViewBag.SuperHero1 = "Batman";
            ViewBag.SuperHero2 = "Superman";
            ViewBag.SuperHeroes = new List<string>() { "Batman", "Superman", "Flash", "Joker", "Catwoman" };
            return View();
        }
        public IActionResult Marvel()
        {
            ViewBag.SuperHero1 = "Spiderman";
            ViewBag.SuperHero2 = "IronMan";
            ViewBag.SuperHeroes = new List<string>() { "Spiderman", "IronMan", "The Hulk", "Thanos"};

            return View();
        }

    }
}
