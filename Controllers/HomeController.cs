using Microsoft.AspNetCore.Mvc;
using Rumuel_Store_ASPN_CursoMod129.Models;
using System.Diagnostics;

namespace Rumuel_Store_ASPN_CursoMod129.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Category(string name, string description)
        {
            ViewData["name"] = name;
            ViewData["description"] = description;

            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Clients()
        {
            return View();
        }

        public IActionResult Sales()
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