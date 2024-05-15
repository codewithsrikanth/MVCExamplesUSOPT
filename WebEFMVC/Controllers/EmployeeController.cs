using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebEFMVC.Models;

namespace WebEFMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            CompanyDBEntities dbContext = new CompanyDBEntities();
            List<EmpDetail> emps = dbContext.EmpDetails.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View(emps);
        }
        public ActionResult Details(int id)
        {
            CompanyDBEntities dbContext = new CompanyDBEntities();
            EmpDetail empDetail = dbContext.EmpDetails.Where(emp=>emp.EmployeeId == id).FirstOrDefault();
            return View(empDetail);
        }
    }
}