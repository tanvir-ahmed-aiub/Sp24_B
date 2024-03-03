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
        [HttpPost]
        public ActionResult Place(double Total) { 
            var order = new Order();
            order.Amount = Total;
            order.Status = "Ordered";
            order.Time = DateTime.Now;
            order.UserId = 1; //session 
            var db = new Sp24_b_PMSEntities();
            db.Orders.Add(order);
            db.SaveChanges();
            var cart = (List<ProductDTO>)Session["cart"];
            foreach (var item in cart) {
                var pd = new ProductOrder();
                pd.Price = item.Price;
                pd.PId = item.Id;
                pd.Qty = item.Qty;
                pd.OrderId = order.Id;
                db.ProductOrders.Add(pd);
            }
            db.SaveChanges();
            Session["cart"] = null;
            TempData["Msg"] = "Order Placed  with Id no " + order.Id;
            return RedirectToAction("Index");
        }
    }
}