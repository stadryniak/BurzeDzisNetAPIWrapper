using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
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

        /// <summary>
        /// Returns City type which contains coordinates of city or throws exception if city does not exist in list or returned data is
        /// incorrect.
        /// </summary>
        /// <param name="cityName">Name of city which coordinates should be found</param>
        /// <returns>City type with coordinates of city</returns>
        /// <exception cref="CityCoordinatesException">Indicates invalid city name or invalid coordinates returned by API</exception>
        public async Task<City> GetCity(string cityName)
        {
            var response = await _api.miejscowoscAsync(cityName, _apiKey);
            if (response.x == null || response.y == null)
            {
                throw new CityCoordinatesException("X or Y coordinates are null");
            }

            if (Math.Abs((float)response.x) < 0.01 && Math.Abs((float)response.y) < 0.01)
            {
                throw new CityCoordinatesException("City not in list");
            }
            var city = new City((float)response.x, (float)response.y);
            return city;
        }

        /// <summary>
        /// Returns weather warnings for given location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>WeatherWarnings type constaining information about all warnings in area</returns>
        public async Task<WeatherWarning> GetWarnings(float x, float y)
        {
            MyComplexTypeOstrzezenia response = await _api.ostrzezenia_pogodoweAsync(y, x, _apiKey);
            return new WeatherWarning(response);
        }

        /// <summary>
        /// Get weather warnings for given city
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public async Task<WeatherWarning> GetCityWarnings(City city)
        {
            return await GetWarnings(city.X, city.Y);
        }

        /// <summary>
        /// Get thunderstorm data for given coordinates and range.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="range"></param>
        /// <returns>Thunderstorm type containing informations about lightning strikes in range</returns>
        public async Task<Thunderstorm> GetThunderstorm(float x, float y, int range = 25)
        {
            MyComplexTypeBurza response = await _api.szukaj_burzyAsync(y.ToString(CultureInfo.InvariantCulture), x.ToString(CultureInfo.InvariantCulture), range, _apiKey);
            return new Thunderstorm(response);
        }

        /// <summary>
        /// Get thunderstorm data for given city
        /// </summary>
        /// <param name="city"></param>
        /// <param name="range"></param>
        /// <returns>Thunderstorm type containing informations about lightning strikes in range</returns>
        public async Task<Thunderstorm> GetCityThunderstorm(City city, int range = 25)
        {
            return await GetThunderstorm(city.X, city.Y, range);
        }

        /// <summary>
        /// List available cities starting with nameFragment in given country
        /// </summary>
        /// <param name="nameFragment">First 3+ characters of city name</param>
        /// <param name="countryCode">ISO 3166 alpha 2 country code</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown if nameFragment is shorter than 3 characters or country code length different than 2</exception>
        public async Task<List<string>> GetCities(string nameFragment, string countryCode)
        {
            if (nameFragment == null || countryCode == null)
            {
                throw new ArgumentException("Arguments can't be null");
            }
            if (nameFragment.Length < 3)
            {
                throw new ArgumentException("nameFragment must be at least 3 characters long");
            }

            if (countryCode.Length != 2)
            {
                throw new ArgumentException("Invalid country code. Expected ISO 3166 alpha 2 code");
            }
            var response = await _api.miejscowosci_listaAsync(nameFragment, countryCode, _apiKey);
            List<string> cityList = new List<string>();
            var matches = Regex.Matches(response, "(\"[^\"]+\")");
            foreach (Match match in matches)
            {
                cityList.Add(match.Groups[1].Value.Substring(1, match.Groups[1].Value.Length - 2));
            }

            cityList.Remove(nameFragment);

            return cityList;
        }

        /// <summary>
        /// This function returns true if provided api key is valid, false otherwise.
        /// </summary>
        /// <param name="apiKey">Your api key</param>
        /// <returns>True if validation succeeded</returns>
        public static async Task<bool> ValidateApiKeyTask(string apiKey)
        {
            if (apiKey == null) return false;
            var api = new serwerSOAPPortClient();
            return await api.KeyAPIAsync(apiKey);
        }
    }
}
