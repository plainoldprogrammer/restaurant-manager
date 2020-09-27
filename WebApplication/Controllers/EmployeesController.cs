using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public EmployeesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("employees/all")]
        public IEnumerable<Employee> GetAllEmployees()
        {
            Console.WriteLine("Request to EmployeesController received");

            RestaurantContext dbContext = new RestaurantContext();

            var employees = dbContext.Employee.Select(x => x);

            return employees;
        }
    }
}
