
namespace BlazorAppCsv.Data;
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

    public async Task SaveCsv()
    {
        var url = "https://localhost:44304/api/CsvTest/data.csv";
        var client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync(url);
        var stream = await response.Content.ReadAsStreamAsync();
        var fileInfo = new FileInfo("reports_2020-11-10 08_14_12.csv");
        using (var fileStream = fileInfo.OpenWrite())
        {
            await stream.CopyToAsync(fileStream);
        }
    }
}
