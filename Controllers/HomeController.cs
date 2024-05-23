using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MainPageModel model = new MainPageModel();
            model.mainPageItems = model.PopulateMainPageItems();
            return View(model);
        }

        public IActionResult Tanks()
        {
            TankPageModel model = new TankPageModel();
            model.tankPageItems = model.PopulateTankPageItems();
            return View(model);
        }
        public IActionResult Damage()
        {
            DamagePageModel model = new DamagePageModel();
            model.damagePageItems = model.PopulateDamagePageItems();
            return View(model);
        }
        public IActionResult Support()
        {
            SupportPageModel model = new SupportPageModel();
            model.supportPageItems = model.PopulateSupportPageItems();
            return View(model);
        }
        [HttpGet]
        public IActionResult Compositions()
        {
             var model = new CompositionsPageModel()
            {
                Question = "What is the best composition?"
            };
            
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Compositions(CompositionsPageModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Compositions", model);
            }
            else
            {
                return View(model);
            }
            

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}