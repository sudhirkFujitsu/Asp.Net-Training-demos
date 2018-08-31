using System;
using System.Web.Mvc;

namespace ActionNameExample.Controllers
{
    public class HomeController : Controller
    {
        [ActionName("Show")]
        public ActionResult Display()
        {
            return View();
        }
    }
}


