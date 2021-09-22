using System;
using System.Threading.Tasks;
using CurrencyCommon.Helpers;
using CurrencyCommon.Models;
using Newtonsoft.Json;

namespace CurrencyConsoleApplication
{
    class Program
    {
        private const string FixerBaseUri = "http://data.fixer.io/api/";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Please select base currency.");
            string baseCurrency = "EUR"; //Console.ReadLine();

            Console.WriteLine("Please select currency for convertion.");
            string conversionCurrency = "USD";//Console.ReadLine();

            Console.WriteLine("Please select the amount of base currency to convert.");
            string amountToConvert = "10"; //Console.ReadLine();

            Console.WriteLine("To get data for a different date. Please enter in the following format 'yyyy-mm-dd'. If current rate wanted, leave blank.");
            string date = Console.ReadLine();




            var queryString = string.IsNullOrWhiteSpace(date)
                ? $"latest?base={baseCurrency}&Symbols={conversionCurrency}"
                : $"{date}?base={baseCurrency}&Symbols={conversionCurrency}";

            var currencyData = await RequestHelpers.SendRequest($"{FixerBaseUri}{queryString}");
            var currencyDataDto = JsonConvert.DeserializeObject<CurrencyResponseDTO>(currencyData);

            var conversionRate = Convert.ToDecimal(currencyDataDto.rates.GetType().GetProperty(conversionCurrency).GetValue(currencyDataDto.rates, null));
            var calculatedConversion = CalculateCurrencyConversion(conversionRate, Convert.ToInt16(amountToConvert));

            Console.WriteLine($"{amountToConvert} {baseCurrency} is {Math.Round(calculatedConversion, 2)} {conversionCurrency}");
        }



        public static decimal CalculateCurrencyConversion(decimal convertionRate, decimal amount)
        {
            return convertionRate * amount;
        }
    }
}
