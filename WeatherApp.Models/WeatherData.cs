using WeatherApp.Models;
using Sys = WeatherApp.Models._WeatherData.Sys;
using Rain = WeatherApp.Models._WeatherData.Rain;
using Snow = WeatherApp.Models._WeatherData.Snow;

namespace WeatherCurrent.Models
{
    public class WeatherData
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int timezoneHours => Timezone / 60 / 60;
        public int Id { get; set; }
        public string Name { get; set; }
        private int Cod { get; set; }

        public WeatherData(Coord coord, List<Weather> weather, string baseInfo, Main main, int visibility, Wind wind, Rain rain, Snow snow, Clouds clouds, int dt, Sys sys, int timezone, int id, string name, int cod)
        {
            Coord = coord;
            Weather = weather;
            Base = baseInfo;
            Main = main;
            Visibility = visibility;
            Wind = wind;
            Rain = rain;
            Snow = snow;
            Clouds = clouds;
            Dt = dt;
            Sys = sys;
            Timezone = timezone;
            Id = id;
            Name = name;
            Cod = cod;
        }
    }

}