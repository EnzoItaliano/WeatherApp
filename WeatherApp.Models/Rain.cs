using Newtonsoft.Json;

namespace WeatherApp.Models._WeatherData
{
    public class Rain : _ForecastData.Rain
    {
        [JsonProperty("1h")]
        public double oneHour { get; set; }
    }
}

namespace WeatherApp.Models._ForecastData
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double threeHours { get; set; }
    }
}