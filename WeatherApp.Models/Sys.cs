using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models._WeatherData
{
    public class Sys
    {
        private int Type { get; set; }
        private int Id { get; set; }
        private int Message { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public DateTime sunriseDateTime => DateTimeOffset.FromUnixTimeSeconds(Sunrise).UtcDateTime;
        public int Sunset { get; set; }
        public DateTime sunsetDateTime => DateTimeOffset.FromUnixTimeSeconds(Sunset).UtcDateTime;
    }
}

namespace WeatherApp.Models._ForecastData
{
    public class Sys
    {
        public string pod { get; set; }
    }
}