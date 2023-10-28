using System.Net.Http.Headers;
using WebMinRouteGroup.Data;

namespace BlazorAppCallWebApi.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }

        public async Task<IEnumerable<Todo>> GetData(int dummy)        
        {
            //string URL = @"https://webminroutegroup20231025213819.azurewebsites.net/todos/v1/";
            string URL = @"https://localhost:49982/todos/v1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            string strres = "";
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Todo[]? todo;
            HttpResponseMessage response = await client.GetAsync(URL);
            var data = await response.Content.ReadAsAsync<IEnumerable<Todo>>();           
            return data;
        }
    }
}