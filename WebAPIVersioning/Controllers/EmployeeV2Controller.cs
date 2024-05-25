using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.Controllers
{
    public class EmployeeV2Controller : ApiController
    {
        static List<EmployeeV2> employees = new List<EmployeeV2>()
        {
            new EmployeeV2(){EmployeeID=1,FirstName="Scott",LastName="Jhon"},
            new EmployeeV2(){EmployeeID=2,FirstName="Scott",LastName="Jhon"},
            new EmployeeV2(){EmployeeID=3,FirstName="Scott",LastName="Jhon"},
            new EmployeeV2(){EmployeeID=4,FirstName="Scott",LastName="Jhon"}
        };
        //[Route("api/v2/employees")]
        public IEnumerable<EmployeeV2> Get()
        {
            return employees;
        }
        //[Route("api/v2/employees/{id}")]
        public EmployeeV2 Get(int id)
        {
            return employees.FirstOrDefault(x => x.EmployeeID == id);
        }
    }
}
