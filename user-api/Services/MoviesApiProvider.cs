using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UserApi.Models;

namespace UserApi.Services
{
    public class MoviesApiProvider
    {
        public async Task<IList<Movie>> GetMovies()
        {
            var moviesApiUrl = System.Environment.GetEnvironmentVariable("MOVIES_API_HOSTNAME", EnvironmentVariableTarget.Process);
            Console.WriteLine(moviesApiUrl);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(moviesApiUrl);

                var response = await client.GetAsync("movie");
                var responseContent = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<IList<Movie>>(responseContent);

                return list;
            }
        }
    }
}