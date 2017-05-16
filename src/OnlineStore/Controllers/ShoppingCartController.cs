﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            //ViewBag.Product.Name = db.Products;
            return View(db.ShoppingCarts.Include(items => items.Product).ToList());
        }

        public IActionResult AddToCart(Product product)
        {

            var cartItem = db.ShoppingCarts.SingleOrDefault(c => c.ProductId == product.Id);

            if (cartItem == null)
            {
                cartItem = new ShoppingCart
                {
                    ProductId = product.Id,
                    ProductCount = 1,
                    Today = DateTime.Now
                };
            
                db.ShoppingCarts.Add(cartItem);
            }

            else
            {
                cartItem.ProductCount++;
            }
            db.SaveChanges();
            return View();
        }

    }
}
