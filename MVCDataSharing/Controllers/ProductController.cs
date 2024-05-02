using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string pname,double price, int qty)
        {
            double total = price * qty;
            ViewData["ProductName"] = pname;
            ViewBag.Total = total;
            return View();
        }

    }
}