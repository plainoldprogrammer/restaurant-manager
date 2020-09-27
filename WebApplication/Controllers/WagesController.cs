using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    public class WagesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WagesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/wages")]
        public IEnumerable<Wages> GetAllEmployees()
        {
            Console.WriteLine("Request to WagesController received");

            RestaurantContext dbContext = new RestaurantContext();
            var wages = dbContext.Wages.Select(x => x);
            return wages;
        }
    }
}
