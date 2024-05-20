using System;
using System.Web.Mvc;

namespace WebLayoutAndPartialViews.Controllers
{
    [HandleError]
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            throw new System.Exception("Something went wrong");
            //return View();
        }
        public ActionResult GetServerTime()
        {            
            return View();
        }

        [HttpPost]
        [OutputCache(Duration = 30)]
        public ActionResult GetServerTime(string t1)
        {
            ViewBag.Msg = "Current Time is: " + DateTime.Now.ToString();
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index1(string t1)
        {
            ViewBag.msg = t1;
            return View();
        }
    }
}