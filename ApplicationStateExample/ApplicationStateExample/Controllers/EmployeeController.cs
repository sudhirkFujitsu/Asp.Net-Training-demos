using ApplicationStateExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationStateExample.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee emp2 = (Employee)ControllerContext.HttpContext.Application["myemployee"];
            ViewBag.emp2 = emp2;
            return View();
        }
    }
}