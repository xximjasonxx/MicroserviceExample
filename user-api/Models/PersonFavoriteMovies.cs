using System.Collections.Generic;
using UserApi.Models;

namespace UserApi.Models
{
    public class PersonFavoriteMovies
    {
        public string Name { get; set; }
        public List<Movie> FavoriteMovies { get; set; }
    }
}