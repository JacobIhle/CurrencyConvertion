using System;
using System.Threading.Tasks;
using CurrencyCommon.Helpers;
using CurrencyCommon.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CurrencyTimedTrigger
{
    public static class GetCurrencyTrigger
    {
        private static readonly string FixerBaseUri = Environment.GetEnvironmentVariable("FixerBaseUri");
        private static readonly string FixerApiKey = Environment.GetEnvironmentVariable("FixerApiKey");


        [FunctionName("GetCurrencyTrigger")]
        public static async Task GetCurrency([TimerTrigger("0 0 10 * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var currencyData = await RequestHelpers.SendRequest($"{FixerBaseUri}/latest?base=EUR", FixerApiKey);
            var currencyDataDto = JsonConvert.DeserializeObject<CurrencyResponseDTO>(currencyData);

            //TODO: Add data to database

        }
    }
}
