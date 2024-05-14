using CRUDMVCwithADO.Models;
using System;
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

        public ActionResult Details(int id)
        {
            Employee emp = context.GetEmployee(id);
            return View(emp);
        }
        public ActionResult Edit(int id)
        {
            Employee emp = context.GetEmployee(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            context.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Employee emp = context.GetEmployee(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(string id)
        {
            int eno = Convert.ToInt32(id);
            context.DeleteEmp(eno);
            return RedirectToAction("Index");
        }
    }
}