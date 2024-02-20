using IntroEFCRUD.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEFCRUD.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            var db = new sp24_bEntities();
            var data = db.Departments.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d) {
            var db = new sp24_bEntities();
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new sp24_bEntities();
            var data = db.Departments.Find(id);
            //(from d in db.Departments where d.Id == id select d).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Department d) {
            var db = new sp24_bEntities();
            var exobj = db.Departments.Find(d.Id);

            //db.Departments.Remove(exobj);
            //db.SaveChanges();
            exobj.Name = d.Name;
            //others
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}