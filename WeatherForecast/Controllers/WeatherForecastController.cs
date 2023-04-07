using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Contracts;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }


        [HttpGet("forecast/{lat},{lon}", Name = "GetWeatherForecast")]
        public async Task<IActionResult> GetCurrentWeather(double lat, double lon)
        {
            var weatherData = await _weatherForecastService.GetWeatherForecastDataAsync(lat, lon);

            if (weatherData == null)
            {
                return NotFound();
            }

            return Ok(weatherData);
        }
    }
}