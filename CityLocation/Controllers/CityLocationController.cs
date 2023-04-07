using CityLocation.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CityLocation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityLocationController : ControllerBase
    {
        private readonly ICityLocationService _cityLocationService;

        private readonly ILogger<CityLocationController> _logger;

        public CityLocationController(ILogger<CityLocationController> logger, ICityLocationService cityLocationService)
        {
            _logger = logger;
            _cityLocationService = cityLocationService;
        }

        [HttpGet("city/{name}", Name = "GetCityInfo")]
        public async Task<IActionResult> GetCityInfo(string name)
        {
            var cityData = await _cityLocationService.GetCityDataAsync(name);

            if (cityData == null)
            {
                return NotFound();
            }

            return Ok(cityData);
        }
    }
}
