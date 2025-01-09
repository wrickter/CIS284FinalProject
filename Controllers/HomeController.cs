using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OverwatchContext _context;

        public HomeController(ILogger<HomeController> logger, OverwatchContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            MainPageModel model = new MainPageModel();
            model.mainPageItems = model.PopulateMainPageItems();
            return View(model);
        }

        public IActionResult Tanks()
        {
            var tankPageItems = _context.Tanks.ToList();
            TankPageModel model = new TankPageModel
            {
                tankPageItems = tankPageItems
            };
            return View(model);
        }
        public IActionResult Damage()
        {
            var damagePageItems = _context.Damage.ToList();
            DamagePageModel model = new DamagePageModel
            {
                damagePageItems = damagePageItems
            };
            return View(model);
        }
        public IActionResult Support()
        {
            var supportPageItems = _context.Support.ToList();
            SupportPageModel model = new SupportPageModel
            {
                supportPageItems = supportPageItems
            };
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