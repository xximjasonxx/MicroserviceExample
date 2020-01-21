using System;
using System.Collections.Generic;
using UserApi.Models;
using System.Linq;

namespace UserApi.Services
{
    public class FavoriteMovieListCreationService
    {
        public IEnumerable<PersonFavoriteMovies> GetFavoriteMovies(IList<Person> people, IList<Movie> movies)
        {
            foreach (var person in people)
            {
                yield return new PersonFavoriteMovies
                {
                    Name = person.Name,
                    FavoriteMovies = GetRandomMovies(movies).ToList()
                };
            }
        }

        Movie[] GetRandomMovies(IList<Movie> allMovies)
        {
            var random = new Random();
            var howMany = random.Next(1, 4);
            var returnArray = new Movie[howMany];

            for (int inc=0; inc<howMany; inc++)
            {
                var index = random.Next(0, allMovies.Count - 1);
                returnArray[inc] = allMovies[index];
            }

            return returnArray.Distinct().ToArray();
        }
    }
}