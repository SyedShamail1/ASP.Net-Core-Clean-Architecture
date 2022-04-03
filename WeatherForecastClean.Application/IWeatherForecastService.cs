using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application
{
    //THIS IS THE SERVICE INTERFACE WHICH IS PRESENT IN THE USE CASE LAYER OF THE ARCHITECTURE LAYER
    //THIS IS USED TO PROCESS DATA PROVIDED BY THE REPOSITORY 
    
    public interface IWeatherForecastService
    {
        List<WeatherForecast> ProcessTemperture();
    }
}
