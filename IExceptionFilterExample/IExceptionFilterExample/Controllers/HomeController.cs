using System;
using System.Collections.Generic;
using System.Web.Mvc;
using IExceptionFilterExample.Filters;

namespace IExceptionFilterExample.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<string> mycountries = new List<string>() { "India", "USA", "UK" };
            ViewBag.CountryName = mycountries[4];
            return View();
        }
    }
}



