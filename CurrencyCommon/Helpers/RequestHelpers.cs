using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyCommon.Helpers
{
    public class RequestHelpers
    {
        public static async Task <string> SendRequest(string uri, string apiKey)
        {
            var requestUri = $"{uri}&access_key={apiKey}";


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
