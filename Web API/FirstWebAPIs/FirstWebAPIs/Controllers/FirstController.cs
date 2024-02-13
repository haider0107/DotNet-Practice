using FirstWebAPIs.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        //[HttpGet("getId/{id}")]
        //public string Get(int id) {
        //    return "Hello my first api";
        //}

        [HttpGet("getEmployee")]
        public Employee Get()
        {
            var E = new Employee() { Id = 1 ,Name="Peter"};
            return E;
        }

        [HttpGet("getAllEmployees/{id?}")]
        public IEnumerable<Employee> Get(int id) //Action
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee() { Id = 102, Name = "Peter" },
                new Employee() { Id =103,Name="Jack" },
                new Employee() { Id =104,Name="Lilly" },
                new Employee() { Id =105,Name="Mark" }

            };
            if (id == 0)
                return emps;
            else
                return emps.Where(x => x.Id == id);
        }
    }
}
