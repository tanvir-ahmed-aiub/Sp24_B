using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Profile()
        {
            var name = "Tanvir";
            var id = 1;
            var cgpa = 3.45f;

            

            ViewBag.Name = name;
            ViewBag.Id = id;
            ViewBag.Cgpa = cgpa;
            return View();
        }
    }
}