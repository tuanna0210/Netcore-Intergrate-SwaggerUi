using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Get the list of employees
        /// </summary>
        /// <returns>The list of employee</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Create an employee
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Employee
        ///     {
        ///        "firstName": "First name",
        ///        "lastName": "Last name",
        ///        "email": "name@gmail.com"
        ///     }
        ///
        /// </remarks>
        /// <param name="employee"></param>
        /// <response code="201">Return a newly created employee</response>
        /// <response code="400">If the employee is null or invalid</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public Employee Post([FromBody] Employee employee)
        {
            return new Employee();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
