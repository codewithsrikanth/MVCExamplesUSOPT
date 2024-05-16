using DataAnnotationsinMVC.Models;
using System.Web.Mvc;

namespace DataAnnotationsinMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Msg = "Inserted Successfully";
            }
            else
            {
                ViewBag.Msg = "Validations Required";
            }
            
            return View();
        }
    }
}