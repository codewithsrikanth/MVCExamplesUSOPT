using System.Collections.Generic;
using System.Web.Mvc;

namespace ViewsInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult Index5()
        {
            var selectList = new SelectList(
        new List<SelectListItem>
        {
            new SelectListItem {Text = "Admin", Value = "Admin"},
            new SelectListItem {Text = "HR", Value = "Human Resource"},
            new SelectListItem {Text = "User", Value = "User"},
        }, "Value", "Text");
            ViewData["Users"] = selectList;
            return View();
        }
    }
}