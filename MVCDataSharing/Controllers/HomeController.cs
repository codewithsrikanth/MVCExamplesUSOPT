using MVCDataSharing.Models;
using System;
using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        //FormCollection
        [HttpPost]
        public ActionResult Index(FormCollection frmObj)
        {
            string pname = frmObj["pname"];
            double price = Convert.ToDouble(frmObj["price"]);
            int qty = Convert.ToInt16(frmObj["qty"]);
            Response.Write("Product Name is: " + pname);
            Response.Write("Total Cost is: " + (price * qty));
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        //Formal Parameter
        [HttpPost]
        public ActionResult Login(string uname,string pwd)
        {
            if(uname == "admin@gmail.com" &&  pwd == "admin@123")
            {
                Response.Write("Login Success");
            }
            else
            {
                Response.Write("Login Failed");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeptInfo()
        {
            return View();
        }
        //Model class object
        [HttpPost]
        public ActionResult DeptInfo(Dept obj)
        {
            Response.Write("DeptID is: " + obj.DeptId);
            Response.Write("<br>Dept Name is: " + obj.DeptName);
            Response.Write("<br>Dept Location is: " + obj.Location);
            return View();
        }

        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details1(int dno, string dname)
        {
            Response.Write("Dept No is: " + dno);
            Response.Write("<br>Dept Name is: " + dname);
            return View();
        }
        [HttpGet]
        public ActionResult Details2(int id)
        {
            Response.Write("DeptID is: " + id);
            return View();
        }
    }
}