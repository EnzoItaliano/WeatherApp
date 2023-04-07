using CityLocation.Contracts;
using CityLocation.Models;
using WeatherApp.Contracts;

namespace CityLocation.Services
{
    public class CityLocationService : ICityLocationService
    {
        private readonly IOpenWeatherMapApiAdapter _adapter;

        public CityLocationService(IOpenWeatherMapApiAdapter adapter)
        {
            _adapter = adapter;
        }

        public async Task<List<CityData>> GetCityDataAsync(string city)
        {
            var apiResponse = await _adapter.GetCityAsync(city);

            List<CityData> cityList = new List<CityData>();
            foreach (var cityRes in apiResponse)
            {
                CityData temp = new CityData(cityRes.name, cityRes.localNames, cityRes.lat, cityRes.lon, cityRes.country);

                cityList.Add(temp);
            }
            
            return cityList;
        }
    }
}
