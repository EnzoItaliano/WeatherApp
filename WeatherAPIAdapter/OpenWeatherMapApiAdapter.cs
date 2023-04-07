using System.Net.Http;
using System.Threading.Tasks;
using CityLocation.Models;
using Newtonsoft.Json;
using WeatherApp.Contracts;
using WeatherApp.Models;
using WeatherCurrent.Models;
using WeatherForecast.Models;

namespace WeatherAPIAdapter
{
    public class OpenWeatherMapApiAdapter : IOpenWeatherMapApiAdapter
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public OpenWeatherMapApiAdapter(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<CityData[]> GetCityAsync(string cityName)
        {
            string url = $"http://api.openweathermap.org/geo/1.0/direct?q={cityName}&limit=5&appid={_apiKey}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            CityData[] weatherApiResponse = JsonConvert.DeserializeObject<CityData[]>(json);

            return weatherApiResponse;
        }

        public async Task<WeatherData> GetWeatherAsync(double lat, double lon)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={_apiKey}&units=metric";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            WeatherData weatherApiResponse = JsonConvert.DeserializeObject<WeatherData>(json);

            return weatherApiResponse;
        }

        public async Task<ForecastData> GetWeatherForecastAsync(double lat, double lon)
        {
            string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={_apiKey}&units=metric";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            ForecastData weatherApiResponse = JsonConvert.DeserializeObject<ForecastData>(json);

            return weatherApiResponse;
        }
    }
}