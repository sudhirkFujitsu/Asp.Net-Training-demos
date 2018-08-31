using System;
using System.Web.Mvc;

namespace SharedViewsExample.Controllers
{
    public class Controller2Controller : Controller
    {
        public ActionResult Contact()
        {
            ViewBag.location = "New York";
            return View();
        }
    }
}


