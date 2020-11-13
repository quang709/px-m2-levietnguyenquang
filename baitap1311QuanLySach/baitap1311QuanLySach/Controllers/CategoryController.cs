using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using baitap1311QuanLySach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baitap1311QuanLySach.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _appDbContext.Categories.Include(p => p.Books);

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

     


       

    }
}