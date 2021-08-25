using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwitterWeather
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string hGWeatherKey = "YOUR WEATHER KEY";
            string hGUrl = $"?key={hGWeatherKey}";

            using var Weather = new HttpClient();

            Weather.BaseAddress = new Uri("https://api.hgbrasil.com/weather");
            Weather.DefaultRequestHeaders.Add("User-Agent", "OAuth gem v0.4.4");
            Weather.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage weatherResponse = await Weather.GetAsync(hGUrl);
            weatherResponse.EnsureSuccessStatusCode();


            // get Weather Response to Json obj
            var respInJson = await weatherResponse.Content.ReadAsStringAsync();
        }
    }
}
