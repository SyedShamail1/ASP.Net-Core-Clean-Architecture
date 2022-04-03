using System;

namespace WeatherForecastClean.Core
{
    //THIS IS THE DOMAIN LAYER IN CLEAN ARCHITECTURE
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
