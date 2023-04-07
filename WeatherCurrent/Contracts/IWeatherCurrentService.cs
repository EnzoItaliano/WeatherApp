using WeatherApp.Models;
using WeatherCurrent.Models;

namespace WeatherCurrent.Contracts
{
    public interface IWeatherCurrentService
    {
        
        Task<WeatherData> GetWeatherDataAsync(double lat, double lon);

    }
}
