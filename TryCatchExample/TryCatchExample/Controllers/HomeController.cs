using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace TryCatchExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                List<string> countries = new List<string>() { "India", "USA", "UK" };
                ViewBag.CountryName = countries[3];
                return View();
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}


