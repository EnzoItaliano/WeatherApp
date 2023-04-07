using WeatherApp.Contracts;
using WeatherForecast.Contracts;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IOpenWeatherMapApiAdapter _adapter;

        public WeatherForecastService(IOpenWeatherMapApiAdapter adapter)
        {
            _adapter = adapter;
        }

        public async Task<ForecastData> GetWeatherForecastDataAsync(double lat, double lon)
        {
            var apiResponse = await _adapter.GetWeatherForecastAsync(lat, lon);
            return apiResponse;
        }
    }
}
