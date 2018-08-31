using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HandleErrorExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> mycountries = new List<string>() { "India", "USA", "UK" };
            ViewBag.CountryName = mycountries[3];
            return View();
        }
    }
}


