using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UserApi.Models;

namespace UserApi.Services
{
    public class NamesApiProvider
    {
        public async Task<IList<Person>> GetNames()
        {
            var namesApiUrl = System.Environment.GetEnvironmentVariable("NAMES_API_HOSTNAME", EnvironmentVariableTarget.Process);
            Console.WriteLine(namesApiUrl);
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(namesApiUrl);
                
                var response = await client.GetAsync("name");
                var responseContent = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<IList<Person>>(responseContent);

                return list;
            }
        }
    }
}