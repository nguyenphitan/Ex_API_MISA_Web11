using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Fresher.Web11.Model;

namespace MISA.Fresher.Web11.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet()]
        public int? GetNumber(int? number, string name)
        {
            return number;
        }

        [HttpPost()]
        public object GetName2([FromHeader] string accessToken, IList<Employee> employees, string? name)
        {
            return new {
                Token = accessToken,
                Name = name,
                Data = employees
            };
        }

        [HttpPut()]
        public object UpdateEmployee(string? employeeCode, string? fullName)
        {
            return "";
        }

        [HttpDelete()]
        public void DeleteEmployee(string? employeeCode)
        {
            
        }


    }
}
