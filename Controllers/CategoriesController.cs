﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rumuel_Store_ASPN_CursoMod129.Data;
using Rumuel_Store_ASPN_CursoMod129.Models;

namespace Rumuel_Store_ASPN_CursoMod129.Controllers
{
    public class CategoriesController : Controller
    {
        public readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
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
        public IActionResult Create(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newCategory);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(newCategory);
        }
    }
}
