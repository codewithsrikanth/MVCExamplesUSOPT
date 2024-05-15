using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebEFMVC.Models;

namespace WebEFMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            CompanyDBEntities dbContext = new CompanyDBEntities();
            List<Department> departments =  dbContext.Departments.ToList();
            return View(departments);
        }
    }
}