using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application
{
    //THIS IS THE SERVICE INTERFACE IMPLEMENTATION SERVICE WHICH IS PRESENT IN THE USE CASE LAYER OF THE ARCHITECTURE LAYER
    //THIS IS USED TO IMPLEMENT THE INTERFACE SERVICE AND PROCESS THE DATA ACCORDING TO THE BUSINESS LAYER'S NEED
    //AFTER FETCHING IT FROM THE REPOSITORY INTERFACE
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repo;

        public WeatherForecastService(IWeatherForecastRepository repo)
        {
            _repo = repo;
        }
        public List<WeatherForecast> ProcessTemperture()
        {
            var forecasts = _repo.GetForecasts();

            var processed = new List<WeatherForecast>();

            foreach (var f in forecasts)
            {
                f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
                processed.Add(f);
            }

            return processed;
        }
    }
}
