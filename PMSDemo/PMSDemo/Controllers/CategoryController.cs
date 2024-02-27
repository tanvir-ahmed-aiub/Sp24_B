using PMSDemo.DTOs;
using PMSDemo.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMSDemo.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var db = new Sp24_b_PMSEntities();
            var data = db.Categories.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create() { 
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoryDTO c) {
            if (ModelState.IsValid) {
                var db = new Sp24_b_PMSEntities();
                //var ct = new Category() { 
                //    Name = c.Name
                //};
                db.Categories.Add(Convert(c));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public static List<CategoryDTO> Convert(List<Category> data) { 
            var list = new List<CategoryDTO>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;
        }
        public static CategoryDTO Convert(Category c) {
            return new CategoryDTO() { 
                Id = c.Id,
                Name = c.Name,
            };
        }
        public static Category Convert(CategoryDTO c){
            return new Category()
            {
                Id = c.Id,
                Name = c.Name,
            };
        }
    }
}