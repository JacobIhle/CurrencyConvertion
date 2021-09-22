using System;
using System.Threading.Tasks;
using CurrencyCommon.Helpers;
using CurrencyCommon.Models;
using Newtonsoft.Json;

namespace CurrencyWebAppReact.Services
{
    public class CurrencyConversionService
    {
        private static readonly string FixerBaseUri = Environment.GetEnvironmentVariable("FixerBaseUri");
        private static readonly string FixerApiKey = Environment.GetEnvironmentVariable("FixerApiKey");


        public static async Task<string> GetAndConvertCurrencyInformation(string baseCurrency, string conversionCurrency, string amountToConvert, string date = "")
        {
            var queryString = string.IsNullOrWhiteSpace(date)
                ? $"latest?base={baseCurrency}&Symbols={conversionCurrency}"
                : $"{date}?base={baseCurrency}&Symbols={conversionCurrency}";

            var currencyData = await RequestHelpers.SendRequest($"{FixerBaseUri}{queryString}", FixerApiKey);
            var currencyDataDto = JsonConvert.DeserializeObject<CurrencyResponseDTO>(currencyData);

            var conversionRate = Convert.ToDecimal(currencyDataDto.rates.GetType().GetProperty(conversionCurrency.ToUpper()).GetValue(currencyDataDto.rates, null));
            var calculatedConversion = CalculateCurrencyConversion(conversionRate, Convert.ToInt16(amountToConvert));

            return calculatedConversion.ToString();
        }

        public static decimal CalculateCurrencyConversion(decimal convertionRate, decimal amount)
        {
            return convertionRate * amount;
        }
    }
}
