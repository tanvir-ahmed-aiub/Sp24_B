using FormSubmission.EF;
using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Person());
        }
        public ActionResult List()
        {
            var db = new sp24_bEntities();
            //var data = db.Users.ToList();
            var data=(from st in db.Users
             where st.Roll >= 1 && st.Roll <= 500
             select st).ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult Index(User p) 
        {
            if (ModelState.IsValid) { //will validate the object based on the rules applied in class
                var db = new sp24_bEntities();
                p.Email = "demo@demo.com";
                db.Users.Add(p);
                db.SaveChanges();
                return RedirectToAction("Contact");
            }
            return View(p);
        }
        //[HttpPost]
        //public ActionResult Index(FormCollection fc) {
        //    string name = fc["Name"];
        //    string uname = fc["Uname"];
        //    return View(fc);
        //}
        //[HttpPost]
        //public ActionResult Index(string Name, string Uname) { 
        //    return View();
        //}
        public ActionResult Index2() { 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}