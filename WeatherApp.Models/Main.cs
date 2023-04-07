using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Main
    {
        public double Temp { get; set; }
        public double tempF => Math.Round(32 + Temp / 0.5556, 2);
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int SeaLevel { get; set; }
        public int GrndLevel { get; set; }
        
        [JsonProperty("temp_kf")]
        private double? TempKf { get; set; }
    }
}
