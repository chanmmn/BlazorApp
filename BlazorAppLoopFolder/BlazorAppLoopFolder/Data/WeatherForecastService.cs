
namespace BlazorAppLoopFolder.Data;
public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }

    public async Task<List<string>> GetDir()
    {
        var url = @"http://localhost:52939/api/values";
        var client = new HttpClient();
        List<string> lst = new List<string>();

        //HttpResponseMessage response = await client.GetAsync(url);
        var result = await client.GetAsync(url);
        //var stream = await response.Content.ReadAsStreamAsync();
        lst = await result.Content.ReadAsAsync<List<string>>();

        //        return "Done";
        return lst;
    }
}
