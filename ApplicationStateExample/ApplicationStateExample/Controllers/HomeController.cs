using System;
using System.Web.Mvc;
using ApplicationStateExample.Models;

namespace ApplicationStateExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee() { EmpID = 201, EmpName = "Smith", Salary = 9000 };
            ControllerContext.HttpContext.Application["myemployee"] = emp;
            return View();
        }

        public ActionResult About()
        {
            Employee emp2 = (Employee)ControllerContext.HttpContext.Application["myemployee"];
            ViewBag.emp2 = emp2;
            return View();
        }
    }
}



