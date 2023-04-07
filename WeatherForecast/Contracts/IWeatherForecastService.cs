using WeatherForecast.Models;

namespace WeatherForecast.Contracts
{
    public interface IWeatherForecastService
    {
        
        Task<ForecastData> GetWeatherForecastDataAsync(double lat, double lon);

    }
}
