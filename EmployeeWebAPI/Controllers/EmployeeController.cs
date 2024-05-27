using EmployeeWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EmployeeWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> Get()
        {
            using(CompanyDBEntities entities = new CompanyDBEntities())
            {
                return entities.Employees.ToList();
            };
        }
    }
}
