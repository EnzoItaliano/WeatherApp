using WeatherApp.Contracts;
using WeatherCurrent.Models;
using WeatherCurrent.Contracts;

namespace WeatherCurrent.Services
{
    public class WeatherCurrentService : IWeatherCurrentService
    {
        private readonly IOpenWeatherMapApiAdapter _adapter;

        public WeatherCurrentService(IOpenWeatherMapApiAdapter adapter)
        {
            _adapter = adapter;
        }

        public async Task<WeatherData> GetWeatherDataAsync(double lat, double lon)
        {
            var apiResponse = await _adapter.GetWeatherAsync(lat, lon);
            return apiResponse;
        }
    }
}
