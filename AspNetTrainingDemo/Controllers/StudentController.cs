using AspNetTrainingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AspNetTrainingDemo.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentID=1, StudentName="mohit", Age = 21 },
                    new Student(){ StudentID=2, StudentName="ashwini", Age = 25 },
                    new Student(){ StudentID=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentID=4, StudentName="Prashant", Age = 28 },
                    new Student(){ StudentID=5, StudentName="Sudhir", Age = 25 } };
        // GET: Student
        public ActionResult Index1()
        {
            ViewData["students"] = studentList;
            TempData["name"] = "Test data";
            TempData["age"] = 30;
            TempData.Keep();
            return View();
        }
        [ActionName("getStudentCount")]
        public ActionResult StudentCount()
        {
            var listOfStudents = ViewData["students"] as IList<Student>;

            ViewBag.TotalStudents = studentList.Count();
            ViewData["TotalStudents1"] = studentList.Count();

            //TempData Example

            string studentName = null;
            int studentAge = 0;

            if (TempData.ContainsKey("name"))
            { studentName = TempData["name"].ToString(); };

            if (TempData.ContainsKey("age"))
            {
                studentAge = int.Parse(TempData["age"].ToString());
            }

            Student std = new Student() { StudentID = 6, StudentName = studentName, Age = studentAge };
            studentList.Add(std);

            //ViewBag.TotalStudents = studentList.Count();
            //ViewData["TotalStudents1"] = studentList.Count();
            
            return View();
        }

        public ActionResult GetAllStudents()
        {
            //Tempdata Keep Example

            //string studentName = null;
            //int studentAge = 0;

            //if (TempData.ContainsKey("name"))
            //{ studentName = TempData["name"].ToString(); };

            //if (TempData.ContainsKey("age"))
            //{
            //    studentAge = int.Parse(TempData["age"].ToString());
            //}
            //Student std = new Student() { StudentID = 6, StudentName = studentName, Age = studentAge };
            //studentList.Add(std);

            //ViewBag.TotalStudents = studentList.Count();
            //ViewData["TotalStudents1"] = studentList.Count();
            return View("StudentCount");
        }
    }
}