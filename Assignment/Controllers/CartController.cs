using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(string id)
        {
            ProductModel productModel = new ProductModel();
            if (TempData["cart"] == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem { Product = productModel.find(id), Quantity = 1 });
                TempData["cart"] = cart;
            }
            else
            {
                List<CartItem> cart = (List<CartItem>)TempData["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartItem { Product = productModel.find(id), Quantity = 1 });
                }
                TempData["cart"] = cart;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remove(string id)
        {
            List<CartItem> cart = (List<CartItem>)TempData["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            TempData["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<CartItem> cart = (List<CartItem>)TempData["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}