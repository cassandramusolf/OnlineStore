using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View();
        }

        public void AddToCart(Product product)
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
        }
    }
}
