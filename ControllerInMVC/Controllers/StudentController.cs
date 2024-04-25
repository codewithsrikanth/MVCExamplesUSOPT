using System.Web.Mvc;

namespace ControllerInMVC.Controllers
{
    public class StudentController : Controller
    {
        //Action method which is used to return a view()
        //Action method which is used to return non-view/data
        //Non-action

        public ViewResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View("ProductList");
        }

        public ContentResult GetEmpName(int empId)
        {
            var emps = new[]
            {
                new {EmpID=101,EmpName="Srikanth",Salary=12000 },
                new {EmpID=102,EmpName="Sai",Salary=39933 },
                new {EmpID=103,EmpName="Cherry",Salary=20202 },
                new {EmpID=104,EmpName="Abhay",Salary=12923 }
            };
            string matchEmpName=string.Empty;
            foreach (var item in emps)
            {
                if(item.EmpID == empId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            return Content(matchEmpName);
        }

        public FilePathResult GetFile(int id)
        {
            string filename = "~/TextFile" + id + ".txt";
            return File(filename, "application/text");
        }

        [NonAction]
        public double CalResult()
        {
            return 12345.95;
        }


        public ActionResult Login(string uname,string pwd)
        {
            if(uname == "admin@gmail.com" && pwd == "admin@123")
            {
                return View();
            }
            else
            {
                return Content("Login Failed");
            }
        }
    }
}