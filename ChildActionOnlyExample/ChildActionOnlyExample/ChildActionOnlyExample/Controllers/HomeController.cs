using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace ChildActionOnlyExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetPhotoGallery()
        {
            List<string> myimages = new List<string>() { "/Images/img1.jpg", "/Images/img2.jpg", "/Images/img3.jpg", "/Images/img4.jpg", "/Images/img5.jpg", "/Images/img6.jpg", "/Images/img7.jpg", "/Images/img8.jpg", "/Images/img9.jpg", "/Images/img10.jpg" };
            ViewBag.myimages = myimages;
            return PartialView("PhotoGallery");
        }
    }
}


