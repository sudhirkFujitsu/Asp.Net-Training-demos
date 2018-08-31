using System;
using System.ComponentModel.DataAnnotations;

namespace StronglyTypedViewsExample.Models
{
    public class Employee
    {
        [Display(Name ="Employee ID")]
        [Required]
        public int EmpID { get; set; }
        [Display(Name = "Employee Name")]
        [Required]
        public string EmpName { get; set; }
        [Display(Name = "Employee Salary")]
        public double Salary { get; set; }
    }
}


