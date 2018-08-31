using System;
using System.Web.Mvc;
using SessionWithObjectsExample.Models;

namespace SessionWithObjectsExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee() { EmpID = 101, EmpName = "Scott", Salary = 8000 };
            Session["myemployee"] = emp;
            return View();
        }

        public ActionResult About()
        {
            Employee emp2 = (Employee)Session["myemployee"];
            ViewBag.emp2 = emp2;
            return View();
        }
    }
}



