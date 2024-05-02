using MVCDataSharing.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            //Prepare the data
            List<Student> students = new List<Student>()
            {
                new Student(){StudentId=101,Name="Srikanth",Gender="Male"},
                new Student(){StudentId=102,Name="Gaythri",Gender="Female"},
                new Student(){StudentId=103,Name="Archana",Gender="Female"},
                new Student(){StudentId=104,Name="Harsha",Gender="Male"}
            };
            //Pass the data 
            return View(students);
        }
    }
}