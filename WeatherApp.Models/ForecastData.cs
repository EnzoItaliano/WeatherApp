using WeatherApp.Models;
using Sys = WeatherApp.Models._ForecastData.Sys;
using Rain = WeatherApp.Models._ForecastData.Rain;
using Snow = WeatherApp.Models._ForecastData.Snow;

namespace WeatherForecast.Models
{
    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
        public double pop { get; set; }
        public Rain rain { get; set; }
        public Snow snow { get; set; }
        public Sys sys { get; set; }
        public string dt_txt { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class ForecastData
    {
        private string cod { get; set; }
        private int message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }

        public ForecastData(string cod, int message, int cnt, List<List> list, City city)
        {
            this.cod = cod;
            this.message = message;
            this.cnt = cnt;
            this.list = list;
            this.city = city;
        }
    }
}
