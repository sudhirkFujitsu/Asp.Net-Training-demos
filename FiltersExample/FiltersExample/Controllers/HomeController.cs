using System;
using System.Web.Mvc;
using FiltersExample.CustomFilters;

namespace FiltersExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new Exception("some error");
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}


