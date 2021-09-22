using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyWebAppReact.Services;

namespace CurrencyWebAppReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConversionController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCurrent()
        {
            var baseCurrency = Request.Query["base"];
            var conversionCurrency = Request.Query["symbols"];
            var amountToConvert = Request.Query["amount"];

            if (string.IsNullOrWhiteSpace(baseCurrency) || string.IsNullOrWhiteSpace(conversionCurrency) ||
                string.IsNullOrWhiteSpace(amountToConvert))
                return new BadRequestObjectResult("One or more data fields missing, please ensure that all required fields are filled out");

            var result = await CurrencyConversionService.GetAndConvertCurrencyInformation(baseCurrency, conversionCurrency, amountToConvert);

            return new OkObjectResult(result);
        }

        [HttpGet("{date}")]
        public async Task<IActionResult> GetFromAnotherDate(string date)
        {
            var baseCurrency = Request.Query["base"];
            var conversionCurrency = Request.Query["symbols"];
            var amountToConvert = Request.Query["amount"];

            if (string.IsNullOrWhiteSpace(baseCurrency) || string.IsNullOrWhiteSpace(conversionCurrency) ||
                string.IsNullOrWhiteSpace(amountToConvert))
                return new BadRequestObjectResult("One or more data fields missing, please ensure that all required fields are filled out");

            var result = await CurrencyConversionService.GetAndConvertCurrencyInformation(baseCurrency, conversionCurrency, amountToConvert, date);

            return new OkObjectResult(result);
        }


        [HttpGet("{baseCurrency}/{symbol}/{amount}")]
        public async Task<IActionResult> GetCurrent(string baseCurrency, string symbol, string amount)
        {
            return new OkObjectResult(await CurrencyConversionService.GetAndConvertCurrencyInformation(baseCurrency, symbol, amount));
        }
    }
}
