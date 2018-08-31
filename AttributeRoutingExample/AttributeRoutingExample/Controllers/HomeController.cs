using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRoutingExample.Controllers
{
    public class HomeController : Controller
    {
        //[Route("index")]
        public ActionResult Action1()
        {
            return View();
        }

        [Route("about")]
        public ActionResult Action2()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Action3()
        {
            return View();
        }
    }
}


