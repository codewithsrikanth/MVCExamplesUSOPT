using System.Linq;
using System.Web.Mvc;
using WebCodeFirstEF.Models;

namespace WebCodeFirstEF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();
            context.Categories.ToList();
            context.Products.ToList();
            return View();
        }
    }
}