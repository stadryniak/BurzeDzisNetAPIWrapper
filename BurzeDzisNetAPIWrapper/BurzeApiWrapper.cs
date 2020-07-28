using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BurzeAPI;
using BurzeDzisAPIWrapper.Types;

namespace BurzeDzisAPIWrapper
{
    public class BurzeApiWrapper
    {
        private readonly string _apiKey;
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
            if (!await ValidateApiKeyTask(apiKey))
            {
                throw new InvalidApiKeyException("Invalid api key");
            }
            return new BurzeApiWrapper(apiKey);
        }

        public async Task<City> GetCity(string cityName)
        {
            var response = await _api.miejscowoscAsync(cityName, _apiKey);
            if (response.x == null || response.y == null)
            {
                throw new CityCoordinatesException("X or Y coordinates are null");
            }
            var city = new City((float)response.x, (float)response.y);
            Console.WriteLine($"x: {city.X}\ty: {city.Y}");
            return city;
        }

        public async Task<WeatherWarning> GetWarnings(float x, float y)
        {
            var response = await _api.ostrzezenia_pogodoweAsync(y, x, _apiKey);
            var warnings = new WeatherWarning(response);
            return warnings;
        }

        public async Task<WeatherWarning> GetCityWarnings(City city)
        {
            return await GetWarnings(city.X, city.Y);
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
