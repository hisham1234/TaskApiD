using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks= new[] { "Task1", "Task2" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return BadRequest();
        }
    }
}
