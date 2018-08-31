using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HtmlHelpersExample.Models;

namespace HtmlHelpersExample.Controllers
{
    public class BankCustomersController : Controller
    {
        public ActionResult Create()
        {
            ViewBag.Countries = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "India", Value = "IND" },
                new SelectListItem() { Text = "United Kingdom", Value = "UK" },
                new SelectListItem() { Text = "United States of America", Value = "USA" }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Create(BankCustomer c)
        {
            IciciBankDbContext db = new IciciBankDbContext();
            db.BankCustomers.Add(c);
            db.SaveChanges();
            return Content("Successfully Registered");
        }
    }
}


