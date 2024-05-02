using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class AccountController : Controller
    {
        // GET: Action
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(username == "admin@gmail.com" && password == "admin@123")
            {
                //What is TempData.Keep() and TempData.Peek() methods?
                TempData["uname"] = username;
                return RedirectToAction("Details");
            }
            else
            {
                ViewData["msg"] = "Invalid Login Details";
                return View();
            }            
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}