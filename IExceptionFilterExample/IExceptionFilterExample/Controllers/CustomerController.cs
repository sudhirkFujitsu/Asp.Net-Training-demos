using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IExceptionFilterExample.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<string> mycountries = new List<string>() { "India", "USA", "UK" };
            ViewBag.CountryName = mycountries[2];
            return View();
        }
    }
}