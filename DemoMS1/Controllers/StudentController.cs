using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var students = new List<string> { "John Doe", "Jane Smith", "Alice Johnson" };
            return Ok(students);
        }
    }
}
