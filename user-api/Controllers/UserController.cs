using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserApi.Services;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly NamesApiProvider _namesApiProvider;
        private readonly MoviesApiProvider _moviesApiProvider;
        private readonly FavoriteMovieListCreationService _listCreationService;

        public UserController()
        {
            _namesApiProvider = new NamesApiProvider();
            _moviesApiProvider = new MoviesApiProvider();
            _listCreationService = new FavoriteMovieListCreationService();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var nameList = await _namesApiProvider.GetNames();
            var moviesList = await _moviesApiProvider.GetMovies();

            return Ok(_listCreationService.GetFavoriteMovies(nameList, moviesList));
        }

    }
}
