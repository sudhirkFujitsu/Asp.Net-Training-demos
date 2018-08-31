using SessionWithObjectsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionWithObjectsExample.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Employee emp2 = (Employee)Session["myemployee"];
            ViewBag.emp2 = emp2;
            return View();
        }
    }
}