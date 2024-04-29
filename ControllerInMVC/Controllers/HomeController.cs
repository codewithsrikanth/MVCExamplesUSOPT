using System;
using System.Web.Mvc;

namespace ControllerInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string empName = "Srikanth";
            double salary = 25000;double inc = 2450;
            Response.Write("Employee Name is: " + empName);
            double totalSalary = GetTotal(salary, inc);
            Response.Write("Total Salary: " + totalSalary);
            return View();
        }
        [NonAction] 
        public double GetTotal(double salary, double inc)
        {
            return salary+inc;
        }
        public ActionResult GetServerTime()
        {
            string str = "Server Time is: " + DateTime.Now.ToString();
            return Content(str);
        }
    }
}