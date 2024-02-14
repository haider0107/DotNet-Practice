using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectInDepth.BOL.DataModel;
using SelectInDepth.DAL;

namespace CrudWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Department> GetDepartments()
        {
            OrganizationDbContext dbContext = new OrganizationDbContext();
            var depts = dbContext.Departments.ToList();
            return depts;
        }
    }
}
