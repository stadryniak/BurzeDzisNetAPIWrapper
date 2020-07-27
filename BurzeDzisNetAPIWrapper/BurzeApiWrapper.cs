using System;
using System.Threading.Tasks;
using BurzeAPI;

namespace BurzeDzisAPIWrapper
{
    public class BurzeApiWrapper
    {
        private string _apiKey;
        private readonly serwerSOAPPortClient _api = new serwerSOAPPortClient();


        private BurzeApiWrapper(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Creates instance of api wrapper. Provided api key is validated.
        /// </summary>
        /// <param name="apiKey">Your api key</param>
        /// <exception cref="InvalidApiKeyException">InvalidApiKeyException is thrown in case of api key validation failure</exception>
        public static async Task<BurzeApiWrapper> Factory(string apiKey)
        {
            if (!await ValidateApiKeyTask(apiKey)) throw new InvalidApiKeyException("Invalid api key");
            return new BurzeApiWrapper(apiKey);
        }

        public async Task<MyComplexTypeMiejscowosc> GetCity(string cityName)
        {
            var res = await _api.miejscowoscAsync(cityName, _apiKey);
            Console.WriteLine($"x: {res.x}\ty: {res.y}");
            return res;
        }

        public async Task<MyComplexTypeOstrzezenia> GetWarnings(float x, float y)
        {
            var res = await _api.ostrzezenia_pogodoweAsync(y, x, _apiKey);
            return res;
        }


        /// <summary>
        /// This function returns true if provided api key is valid, false otherwise.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns>True if validation succeeded</returns>
        public static async Task<bool> ValidateApiKeyTask(string apiKey)
        {
            if (apiKey == null) return false;
            var api = new serwerSOAPPortClient();
            return await api.KeyAPIAsync(apiKey);
        }
    }
}
