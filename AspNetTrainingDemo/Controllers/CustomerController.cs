using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetTrainingDemo.Controllers
{
    public class CustomerController : Controller
    {
        //this is for demostrating state management techniques
        public ActionResult Index()
        {
            return View();
        }
    }
}