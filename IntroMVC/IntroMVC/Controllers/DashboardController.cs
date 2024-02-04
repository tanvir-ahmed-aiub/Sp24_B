using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroMVC.Models;

namespace IntroMVC.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Profile()
        {
            var s1 = new Student();
            s1.name = "Tanvir";
            s1.id = "1";
            s1.cgpa = 3.45f;

            var s2 = new Student();
            s2.name = "Sabbir";
            s2.id = "2";
            s2.cgpa = 3.0f;

            Student[] students = new Student[] { s1, s2 };

            ViewBag.Students = students;                   
            return View();
        }
    }
}