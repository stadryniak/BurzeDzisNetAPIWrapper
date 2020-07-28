using System;
using System.Globalization;
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
            if (response.x == null || response.y == null )
            {
                throw new CityCoordinatesException("X or Y coordinates are null");
            }

            if (Math.Abs((float) response.x) < 0.01 && Math.Abs((float) response.y) < 0.01)
            {
                throw new CityCoordinatesException("Api returned invalid coordinates (0,0)");
            }
            var city = new City((float)response.x, (float)response.y);
            return city;
        }

        public async Task<WeatherWarning> GetWarnings(float x, float y)
        {
            MyComplexTypeOstrzezenia response = await _api.ostrzezenia_pogodoweAsync(y, x, _apiKey);
            return new WeatherWarning(response);
        }

        public async Task<WeatherWarning> GetCityWarnings(City city)
        {
            return await GetWarnings(city.X, city.Y);
        }

        public async Task<Thunderstorm> GetThunderstorm(float x, float y, int range = 25)
        {
            MyComplexTypeBurza response = await _api.szukaj_burzyAsync(y.ToString(CultureInfo.InvariantCulture), x.ToString(CultureInfo.InvariantCulture), range, _apiKey);
            return new Thunderstorm(response);
        }

        public async Task<Thunderstorm> GetCityThunderstorm(City city, int range = 25)
        {
            return await GetThunderstorm(city.X, city.Y, range);
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
