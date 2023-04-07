using Newtonsoft.Json;

namespace WeatherApp.Models._WeatherData
{
    public class Snow : _ForecastData.Snow
    {
        [JsonProperty("1h")]
        public double oneHour { get; set; }
    }
}

namespace WeatherApp.Models._ForecastData
{
    public class Snow
    {
        [JsonProperty("3h")]
        public double threeHours { get; set; }
    }
}