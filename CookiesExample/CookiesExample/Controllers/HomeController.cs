using System;
using System.Web;
using System.Web.Mvc;

namespace CookiesExample.Controllers
{
    public class HomeController : Controller
    {
        [ActionName("Display")]
        public ActionResult Index()
        {
            HttpCookie ck = new HttpCookie("x", "hello");
            Response.Cookies.Add(ck);
            return View("index");
        }

        public ActionResult About()
        {
            ViewBag.msg = Request.Cookies["x"].Value;
            return View();
        }
    }
}



