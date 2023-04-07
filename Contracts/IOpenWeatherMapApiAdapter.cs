using CityLocation.Models;
using WeatherCurrent.Models;
using WeatherForecast.Models;

namespace WeatherApp.Contracts
{
    public interface IOpenWeatherMapApiAdapter
    {
        Task<CityData[]> GetCityAsync(string location);

        Task<WeatherData> GetWeatherAsync(double lat, double lon);

        Task<ForecastData> GetWeatherForecastAsync(double lat, double lon);
    }
}
