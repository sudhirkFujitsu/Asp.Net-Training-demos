using System;
using System.Web.Mvc;
using FormsExample.Models;

namespace FormsExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //example with request.form
        //[HttpPost]
        //public ActionResult Register()
        //{
        //    User u = new User();
        //    string firstname = Request.Form["firstname"];
        //    string lastname = Request.Form["lastname"];
        //    string email = Request.Form["email"];
        //    string mobile = Request.Form["mobile"];
        //    string newsletters = Request.Form["newsletters"];
        //    string gender = Request.Form["gender"];
        //    string country = Request.Form["country"];

        //    string msg = "Firstname: " + firstname + "<br>Lastname: " + lastname + "<br>Email: " + email + "<br>Mobile: " + mobile + "<br>News letters: " + newsletters + "<br>Gender: " + gender + "<br>Country: " + country;
        //    return Content(msg);
        //}


        ////example with request.querystring
        //[HttpGet]
        //public ActionResult Register()
        //{

        //    string firstname = Request.QueryString["firstname"];
        //    string lastname = Request.QueryString["lastname"];
        //    string email = Request.QueryString["email"];
        //    string mobile = Request.QueryString["mobile"];
        //    string newsletters = Request.QueryString["newsletters"];
        //    string gender = Request.QueryString["gender"];
        //    string country = Request.QueryString["country"];
        //    string msg = "Firstname: " + firstname + "<br>Lastname: " + lastname + "<br>Email: " + email + "<br>Mobile: " + mobile + "<br>News letters: " + newsletters + "<br>Gender: " + gender + "<br>Country: " + country;
        //    return Content(msg);
        //}

        [HttpPost]
        public ActionResult Register(User u)
        {
            string msg = "Firstname: " + u.firstname + "<br>Lastname: " + u.lastname + "<br>Email: " + u.email + "<br>Mobile: " + u.mobile + "<br>News letters: " + u.newsletters + "<br>Gender: " + u.gender + "<br>Country: " + u.country;
            return Content(msg);
        }
    }
}


