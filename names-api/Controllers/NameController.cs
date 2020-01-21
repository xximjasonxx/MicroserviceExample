using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NamesApi.Models;

namespace NamesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly Person[] Names = new[]
        {
            new Person { Name = "Steve", Id = 1 },
            new Person { Name = "Brenda", Id = 2 },
            new Person { Name = "Jason", Id = 3 },
            new Person { Name = "Katie", Id = 4 },
            new Person { Name = "Sean", Id = 5 },
            new Person { Name = "Claire", Id = 6 },
            new Person { Name = "Cory", Id = 7 },
            new Person { Name = "Nichole", Id = 8 },
            new Person { Name = "Madeline", Id = 9 },
            new Person { Name = "Ethan", Id = 10 },
            new Person { Name = "Ellison", Id = 11 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Names);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Names.FirstOrDefault(x => x.Id == id));
        }
    }
}
