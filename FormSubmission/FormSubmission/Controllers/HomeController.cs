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
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(FormCollection fc) {
        //    string name = fc["Name"];
        //    string uname = fc["Uname"];
        //    return View(fc);
        //}
        [HttpPost]
        public ActionResult Index(string Name, string Uname) { 
            return View();
        }
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