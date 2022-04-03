using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastClean.Application;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.APILayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherService;
        private readonly IUsersService _userService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherService, IUsersService userService)
        {
            _logger = logger;
            _weatherService = weatherService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _weatherService.ProcessTemperture();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUsersWithSName(int id)
        {
            var result = _userService.GetUsers();
            return Ok(result);
        }
    }
}
