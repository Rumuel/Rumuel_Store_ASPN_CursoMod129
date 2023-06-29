using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rumuel_Store_ASPN_CursoMod129.Data;
using Rumuel_Store_ASPN_CursoMod129.Models;

namespace Rumuel_Store_ASPN_CursoMod129.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newProduct);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }  
            return View(newProduct);
        }
    }
}
