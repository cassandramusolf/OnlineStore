using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Mens()
        {
            return View(db.Products);
        }

        public IActionResult Womens()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Accessories()
        {
            return View(db.Products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
