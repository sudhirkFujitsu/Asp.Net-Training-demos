using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NonActionExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Square()
        {
            ViewBag.Result = Multiply(10, 10);
            return View();
        }

        public ActionResult Cube()
        {
            ViewBag.Result = Multiply(Multiply(10, 10), 10);
            return View();
        }

        [NonAction]
        public int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }

        [NonAction]
        public ActionResult Devide(int a, int b)
        {
            int c = a * b;
            return View();
        }
    }
}


