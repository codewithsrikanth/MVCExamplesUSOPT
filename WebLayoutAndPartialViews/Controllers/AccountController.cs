using System.Web.Mvc;
using System.Web.Security;

namespace WebLayoutAndPartialViews.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Blogs()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if(username == "admin@gmail.com" && password == "admin@123")
            {
                FormsAuthentication.RedirectFromLoginPage(username,false);
                return View();
            }
            else
            {
                ViewBag.msg = "Invalid credentails";
                return View();
            }            
        }
    }
}