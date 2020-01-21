using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static readonly Movie[] Movies = new[]
        {
            new Movie { Name = "Avengers", Id = 1 },
            new Movie { Name = "Babylon", Id = 2 },
            new Movie { Name = "Captain Marvel", Id = 3 },
            new Movie { Name = "Deathly Hallows", Id = 4 },
            new Movie { Name = "Endgame", Id = 5 },
            new Movie { Name = "Fast and Furious", Id = 6 },
            new Movie { Name = "Guardians of the Galaxy", Id = 7 },
            new Movie { Name = "Hulk", Id = 8 },
            new Movie { Name = "Ice Age", Id = 9 },
            new Movie { Name = "Jumanji", Id = 10 },
            new Movie { Name = "Killjoy", Id = 11 },
            new Movie { Name = "Last Samurai", Id = 12 },
            new Movie { Name = "Midnight Madness", Id = 13 },
            new Movie { Name = "No Country for Old Men", Id = 14 },
            new Movie { Name = "Oceans 11", Id = 15 },
            new Movie { Name = "Pans Labyrinth", Id = 16 },
            new Movie { Name = "Quantum of Solace", Id = 17 },
            new Movie { Name = "Rise of Skywalker", Id = 18 },
            new Movie { Name = "Spider Man", Id = 19 },
            new Movie { Name = "Taxi Driver", Id = 20 },
            new Movie { Name = "United 93", Id = 21 },
            new Movie { Name = "Vertigo", Id = 22 },
            new Movie { Name = "War Games", Id = 23 },
            new Movie { Name = "X-Men: The Last Stand", Id = 24 },
            new Movie { Name = "You've Got Mail", Id = 25 },
            new Movie { Name = "Zodiac", Id = 26 }
        };

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Movies.FirstOrDefault(x => x.Id == id));
        }
    }
}
