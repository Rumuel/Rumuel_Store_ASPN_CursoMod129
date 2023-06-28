using Microsoft.AspNetCore.Mvc;

namespace Rumuel_Store_ASPN_CursoMod129.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
