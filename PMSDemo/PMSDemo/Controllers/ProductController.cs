using PMSDemo.DTOs;
using PMSDemo.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMSDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var db = new Sp24_b_PMSEntities();
            var data = db.Products.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create()
        {
            var db = new Sp24_b_PMSEntities();
            //temp using ef models
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductDTO p)
        {
            if (ModelState.IsValid)
            {
                var db = new Sp24_b_PMSEntities();
                //var ct = new Product() { 
                //    Name = c.Name
                //};
                db.Products.Add(Convert(p));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var db2 = new Sp24_b_PMSEntities();
            //temp using ef models
            ViewBag.Categories = db2.Categories.ToList();
            return View();
        }

        public static List<ProductDTO> Convert(List<Product> data)
        {
            var list = new List<ProductDTO>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;
        }
        public static ProductDTO Convert(Product p)
        {
            return new ProductDTO()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                C_Id = p.C_Id
            };
        }
        public static Product Convert(ProductDTO p)
        {
            return new Product()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                C_Id = p.C_Id
            };
        }


    }
}