using System;
using System.Web.Mvc;

namespace OutputCacheExample.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 120)]
        public ActionResult Index()
        {
            ViewBag.SysTime = DateTime.Now.ToString();
            return View();
        }
    }
}


