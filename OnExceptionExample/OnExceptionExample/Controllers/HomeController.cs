using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnExceptionExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> mycountries = new List<string>() { "India", "USA", "UK" };
            ViewBag.CountryName = mycountries[3];
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            filterContext.ExceptionHandled = true;
            filterContext.Controller.ViewBag.Message = filterContext.Exception.Message;
            filterContext.Result = View("Error");
        }
    }
}


