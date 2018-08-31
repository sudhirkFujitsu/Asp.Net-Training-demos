using System;
using System.Web.Mvc;

namespace SharedViewsExample.Controllers
{
    public class Controller1Controller : Controller
    {

        public ActionResult Contact()
        {
            ViewBag.location = "Hyderabad";
            return View();
        }

        public ActionResult index()
        {
            ViewBag.location = "Hyderabad";
            return View();
        }
    }
}


