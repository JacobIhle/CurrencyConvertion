using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConversionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CurrencyConversionController> _logger;

        public CurrencyConversionController(ILogger<CurrencyConversionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CurrencyConvertion> GetCurrent()
        {

            var baseCurrency = Request.Query["base"];
            var convesionCurrency = Request.Query["symbols"];


            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CurrencyConvertion
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
