using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rumuel_Store_ASPN_CursoMod129.Data;
using Rumuel_Store_ASPN_CursoMod129.Models;

namespace Rumuel_Store_ASPN_CursoMod129.Controllers
{
    public class ClientsController : Controller
    {
        public readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client newClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newClient);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(newClient);
        }
    }
}
