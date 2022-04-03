using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application
{
    public interface IUsersService
    {
        List<Users> GetUsers();
    }
}
