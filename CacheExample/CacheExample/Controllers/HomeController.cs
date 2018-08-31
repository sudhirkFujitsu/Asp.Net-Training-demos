using System;
using System.Web.Mvc;
using CacheExample.Models;

namespace CacheExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee() { EmpID = 301, EmpName = "Ford", Salary = 8000 };
            ControllerContext.HttpContext.Cache.Insert("myemployee", emp, null, DateTime.Now.AddMinutes(5), TimeSpan.Zero);
            return View();
        }

        public ActionResult About()
        {
            Employee emp2 = (Employee)ControllerContext.HttpContext.Cache["myemployee"];
            ViewBag.emp2 = emp2;
            return View();
        }
    }
}


