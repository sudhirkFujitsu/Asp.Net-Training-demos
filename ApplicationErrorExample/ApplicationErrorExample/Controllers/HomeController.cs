using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ApplicationErrorExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int a = 10;
            int b = 0;
            int c = a / b;
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}


