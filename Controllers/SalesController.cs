using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rumuel_Store_ASPN_CursoMod129.Data;
using Rumuel_Store_ASPN_CursoMod129.Models;

namespace Rumuel_Store_ASPN_CursoMod129.Controllers
{
    public class SalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Sale newSale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newSale);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Description");
            return View(newSale);
        }
    }
}
