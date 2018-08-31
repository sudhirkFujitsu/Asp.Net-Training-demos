using System;
using System.Web.Mvc;

namespace SessionExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["message"] = "Hello from session";
            return View();
        }

        public ActionResult About()
        {
            string s = Convert.ToString(Session["message"]);
            ViewBag.s = s;
            return View();
        }
    }
}


