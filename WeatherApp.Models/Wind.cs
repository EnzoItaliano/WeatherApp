using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Wind
    {
        public double Speed { get; set; }
        public double speedMilesHour => Math.Round(2.236936 * Speed, 2);
        public int Deg { get; set; }
        public double Gust { get; set; }
        public double gustMilesHour => Math.Round(2.236936 * Gust, 2);
    }
}