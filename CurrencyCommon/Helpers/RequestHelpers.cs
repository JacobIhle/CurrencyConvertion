using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConsoleApplication.Helpers
{
    public class RequestHelpers
    {
        private static readonly string FixerApiKey = Environment.GetEnvironmentVariable("FixerApiKey");


        public static async Task <string> SendRequest(string uri)
        {
            var requestUri = $"{uri}&access_key={FixerApiKey}";


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(requestUri)
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            var responsebody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return responsebody;
            }
            else
            {
                Console.WriteLine($"Error while trying to retrieve data from {requestUri}. \n The response was: {responsebody}");
                return string.Empty;
            }


        }
    }
}
