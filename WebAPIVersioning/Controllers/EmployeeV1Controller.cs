using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.Controllers
{
    public class EmployeeV1Controller : ApiController
    {
        static List<EmployeeV1> employees = new List<EmployeeV1>()
        {
            new EmployeeV1(){EmployeeID=1,EmployeeName="Srikanth"},
            new EmployeeV1(){EmployeeID=2,EmployeeName="Raju"},
            new EmployeeV1(){EmployeeID=3,EmployeeName="Ramesh"},
            new EmployeeV1(){EmployeeID=4,EmployeeName="Krish"}            
        };

        //[Route("api/v1/employees")]
        public IEnumerable<EmployeeV1> Get()
        { 
            return employees;
        }
        //[Route("api/v1/employees/{id}")]
        public EmployeeV1 Get(int id)
        {
            return employees.FirstOrDefault(x=>x.EmployeeID==id);
        }
    }
}
