using System;
using System.Web.Mvc;
using StronglyTypedViewsExample.Models;
using System.Collections.Generic;

namespace StronglyTypedViewsExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee();
            emp.EmpID = 101;
            emp.EmpName = "Sudhir";
            emp.Salary = 7000;
            return View(emp);
        }

        public ActionResult Index2()
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Sudhir", Salary = 8000 },
                new Employee() { EmpID = 102, EmpName = "Rohit", Salary = 6400 },
                new Employee() { EmpID = 103, EmpName = "Mohit", Salary = 9700 },
                new Employee() { EmpID = 104, EmpName = "chandan", Salary = 5700 },
                new Employee() { EmpID = 105, EmpName = "Sumit", Salary = 6200 },
            };
            return View(emps);
        }

        public ActionResult Index3()
        {
            List<Employee> e = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Sudhir", Salary = 8000 },
                new Employee() { EmpID = 102, EmpName = "Rohit",  Salary = 6400 },
                new Employee() { EmpID = 103, EmpName = "Mohit",  Salary = 9700 },
                new Employee() { EmpID = 104, EmpName = "chandan", Salary = 5700 },
                new Employee() { EmpID = 105, EmpName = "Sumit", Salary = 6200 }
            };

            List<Product> p = new List<Product>()
            {
                new Product() { ProductID = 101, ProductName = "TV", Cost = 77882 },
                new Product() { ProductID = 102, ProductName = "AC", Cost = 44131 },
                new Product() { ProductID = 103, ProductName = "Mobile", Cost = 88333 }
            };

            ViewModel vm = new ViewModel();
            vm.emps = e;
            vm.prods = p;

            return View(vm);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            string msg = "employee Id:" + emp.EmpID + " employee name:" + emp.EmpName + "employee salary:" + emp.Salary;
            return Content(msg);
        }

    }
}


