using System;
using System.Web.Mvc;

namespace RoutePrefixExample.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : Controller
    {
        [Route("Show/{categoryname?}")]
        public ActionResult Show(string categoryname)
        {
            ViewBag.categoryname = categoryname;
            return View();
        }

        [Route("DisplaySingle/{id:int}")]
        public ActionResult DisplaySingle(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [Route("Search")]
        public ActionResult Search()
        {
            return View();
        }

        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }
    }
}



