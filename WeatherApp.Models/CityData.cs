using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLocation.Models
{
    public class CityData
    {
        public string name { get; set; }
        public Dictionary<string, string> localNames { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string country { get; set; }

        public CityData(string name, Dictionary<string,string> localNames, double lat, double lon, string country)
        {
            this.name = name;
            this.localNames = localNames;
            this.lat = lat;
            this.lon = lon;
            this.country = country;
        }
    }
}
