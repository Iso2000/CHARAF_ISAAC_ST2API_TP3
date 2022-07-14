using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TP3.API;

namespace TP3
{
    
        
    public class Api
    {
        private string _key;
        private string _url = "https://api.openweathermap.org/data/2.5/weather";
        private HttpClient _client;

        public Api()
        {
            _key = "dc30fe9f8626b0e1dcdb24030931d64c";
            _client = new HttpClient();
        }

        public Root Request(City city)
        {
            
            string url = $"{_url}?q={city._name}&appid={_key}";
            // Console.ReadKey();
            var json = GetData(url).GetAwaiter().GetResult();
            Root data = JsonConvert.DeserializeObject<Root>(json.ToString());
            return data;

        }

        public async Task<string> GetData(string url)
        {
            using (var response = await _client.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
        }
    }
}
