using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace TempDataExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Action1()
        {
            TempData["Message"] = "Message from Action 1";
            return RedirectToAction("Action2", "Home");
        }

        public ActionResult Action2()
        {
            ViewBag.x = TempData["Message"];
            
            return RedirectToAction("Action3", "Home");
        }

        public ActionResult Action3()
        {
            ViewBag.msg = TempData["Message"];
            return View();
        }
    }
}


