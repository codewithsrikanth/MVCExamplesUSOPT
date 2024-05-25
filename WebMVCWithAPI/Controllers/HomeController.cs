using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Mvc;
using WebMVCWithAPI.Models;

namespace WebMVCWithAPI.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            var url = "http://localhost:50696/api/Employee";
            HttpResponseMessage resObj =  client.GetAsync(url).Result;
            List<Employee> emps = resObj.Content.ReadAsAsync<List<Employee>>().Result;
            return View(emps);
        }

        public ActionResult Details(int id)
        {
            var url = "http://localhost:50696/api/Employee/"+id;
            HttpResponseMessage resObj = client.GetAsync(url).Result;
            Employee emp = resObj.Content.ReadAsAsync<Employee>().Result;
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            var url = "http://localhost:50696/api/Employee";
            HttpResponseMessage resObj = client.PostAsJsonAsync<Employee>(url, emp).Result;
            var res = resObj.Content.ReadAsAsync<string>().Result;
            ViewBag.response = res;
            return View();
        }
    }
}