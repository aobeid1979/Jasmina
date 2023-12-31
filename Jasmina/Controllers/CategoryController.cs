﻿using Jasmina.Data;
using Jasmina.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jasmina.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Course> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
