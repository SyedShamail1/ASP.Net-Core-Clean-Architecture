using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application
{
    //THIS IS THE RESPOSITORY INTERFACE WHICH IS PRESENT IN THE USE CASE LAYER OF THE ARCHITECTURE LAYER
    //IT IS USED TO RETRIEVE INFORMATION FROM THE DATABASE ETC
    public interface IWeatherForecastRepository
    {
        WeatherForecast[] GetForecasts();
    }
}
