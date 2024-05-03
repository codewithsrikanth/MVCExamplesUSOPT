using CRUDMVCwithADO.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CRUDMVCwithADO.Controllers
{
    public class HomeController : Controller
    {
        CompanyDBDataContext context = new CompanyDBDataContext();
        public ActionResult Index()
        {
            List<Employee> employees = context.GetEmployees();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            context.InsertEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}