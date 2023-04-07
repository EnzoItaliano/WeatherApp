using Microsoft.AspNetCore.Mvc;
using WeatherCurrent.Contracts;

namespace WeatherCurrent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherCurrentController : ControllerBase
    {
        private readonly IWeatherCurrentService _weatherCurrentService;

        private readonly ILogger<WeatherCurrentController> _logger;

        public WeatherCurrentController(ILogger<WeatherCurrentController> logger, IWeatherCurrentService weatherCurrentService)
        {
            _logger = logger;
            _weatherCurrentService = weatherCurrentService;
        }

        [HttpGet("weather/{lat},{lon}", Name = "GetCurrentWeather")]
        public async Task<IActionResult> GetCurrentWeather(double lat, double lon)
        {
            var weatherData = await _weatherCurrentService.GetWeatherDataAsync(lat, lon);

            if (weatherData == null)
            {
                return NotFound();
            }

            return Ok(weatherData);
        }
    }
}