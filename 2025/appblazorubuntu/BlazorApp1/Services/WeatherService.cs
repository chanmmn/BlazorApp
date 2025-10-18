using System;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }

    public class WeatherService : IWeatherService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            var rng = new Random();
            var forecasts = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast(
                    DateTime.Now.AddDays(index),
                    rng.Next(-20, 55),
                    Summaries[rng.Next(Summaries.Length)]
                )
            ).ToArray();

            return Task.FromResult(forecasts);
        }
    }
}
