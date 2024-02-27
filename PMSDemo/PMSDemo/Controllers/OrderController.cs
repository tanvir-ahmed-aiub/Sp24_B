using PMSDemo.DTOs;
using PMSDemo.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMSDemo.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            var db = new Sp24_b_PMSEntities();
            var products = ProductController.Convert(db.Products.ToList());
            return View(products);
        }
        public ActionResult addtocart(int id) {
            var db = new Sp24_b_PMSEntities();
            var product = ProductController.Convert(db.Products.Find(id));
            product.Qty = 1;
            if (Session["cart"] == null)
            {
                var cart = new List<ProductDTO>();
                cart.Add(product);
                Session["cart"] = cart; //boxing
            }
            else {
                var cart = (List<ProductDTO>)Session["cart"]; //unboxing
                cart.Add(product);
                Session["cart"] = cart;

            }
            TempData["Msg"] = "Product Added to cart";
            return RedirectToAction("Index");
        }

        public ActionResult Cart() {
            if (Session["cart"] == null) {
                TempData["Msg"] = "Cart is empty";
                return RedirectToAction("Index");
            }
            var cart = (List<ProductDTO>)Session["cart"];
            return View(cart);
        }
    }
}