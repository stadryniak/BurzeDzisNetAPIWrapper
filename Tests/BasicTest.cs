using System;
using System.IO;
using System.Threading.Tasks;
using BurzeDzisAPIWrapper;
using BurzeDzisAPIWrapper.Types;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace Tests
{
    public class Tests
    {
        private IConfiguration _configuration;

        public Tests()
        {
            var builder = new ConfigurationBuilder().AddUserSecrets<Tests>();
            _configuration = builder.Build();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async Task ValidateApiKeyTest()
        {
            Assert.IsTrue(await BurzeApiWrapper.ValidateApiKeyTask(_configuration["api_key"]));

            Assert.IsFalse(await BurzeApiWrapper.ValidateApiKeyTask("acbe8d842ds01z3b1dc5406sb0083f9717d04574"));
            Assert.IsFalse(await BurzeApiWrapper.ValidateApiKeyTask(""));
            Assert.IsFalse(await BurzeApiWrapper.ValidateApiKeyTask("132"));
            Assert.IsFalse(await BurzeApiWrapper.ValidateApiKeyTask(null));
        }

        [Test]
        public void FactoryExceptionTest()
        {
            Assert.ThrowsAsync<InvalidApiKeyException>(async () => await BurzeApiWrapper.Factory("a"));
            Assert.DoesNotThrowAsync(async () => await BurzeApiWrapper.Factory(_configuration["api_key"]));
        }

        [Test]
        public async Task GetCityTest()
        {
            var api = await BurzeApiWrapper.Factory(_configuration["api_key"]);
            Assert.DoesNotThrowAsync(async () => await api.GetCity("Warszawa".ToLower()));
            Assert.DoesNotThrowAsync(async () => await api.GetCity("warszawa".ToLower()));
            Assert.DoesNotThrowAsync(async () => await api.GetCity("Ostrowiec Swietokrzyski".ToLower()));
        }

        [Test]
        public async Task GetWarningsTest()
        {
            var api = await BurzeApiWrapper.Factory(_configuration["api_key"]);
            var city = await api.GetCity("ostrowiec swietokrzyski");
            var warnings = await api.GetWarnings(city.X, city.Y);
            //Thunderstorm
            Console.WriteLine("Thunderstorm");
            if (warnings.Thunderstorm > 0)
            {
                Console.WriteLine(warnings.ThunderstormStart);
                Console.WriteLine(warnings.ThunderstormEnd);
            }
            //Cold
            Console.WriteLine("Cold");
            if (warnings.Cold > 0)
            {
                Console.WriteLine(warnings.ColdStart);
                Console.WriteLine(warnings.ColdEnd);
            }
            //Heat
            Console.WriteLine("Heat");
            if (warnings.Heat > 0)
            {
                Console.WriteLine(warnings.HeatStart);
                Console.WriteLine(warnings.HeatEnd);
            }
            //Wind
            Console.WriteLine("Wind");
            if (warnings.Wind > 0)
            {
                Console.WriteLine(warnings.WindStart);
                Console.WriteLine(warnings.WindEnd);
            }
            //Rain
            Console.WriteLine("Rain");
            if (warnings.Rain > 0)
            {
                Console.WriteLine(warnings.RainStart);
                Console.WriteLine(warnings.RainEnd);
            }
            //Tornado
            Console.WriteLine("Tornado");
            if (warnings.Tornado > 0)
            {
                Console.WriteLine(warnings.TornadoStart);
                Console.WriteLine(warnings.TornadoEnd);
            }
        }

        [Test]
        public async Task GetCityWarningsTest()
        {
            var api = await BurzeApiWrapper.Factory(_configuration["api_key"]);
            var city = await api.GetCity("ostrowiec swietokrzyski");
            WeatherWarning warnings = await api.GetCityWarnings(city);
            //Thunderstorm
            Console.WriteLine("Thunderstorm");
            if (warnings.Thunderstorm > 0)
            {
                Console.WriteLine(warnings.ThunderstormStart);
                Console.WriteLine(warnings.ThunderstormEnd);
            }
            //Cold
            Console.WriteLine("Cold");
            if (warnings.Cold > 0)
            {
                Console.WriteLine(warnings.ColdStart);
                Console.WriteLine(warnings.ColdEnd);
            }
            //Heat
            Console.WriteLine("Heat");
            if (warnings.Heat > 0)
            {
                Console.WriteLine(warnings.HeatStart);
                Console.WriteLine(warnings.HeatEnd);
            }
            //Wind
            Console.WriteLine("Wind");
            if (warnings.Wind > 0)
            {
                Console.WriteLine(warnings.WindStart);
                Console.WriteLine(warnings.WindEnd);
            }
            //Rain
            Console.WriteLine("Rain");
            if (warnings.Rain > 0)
            {
                Console.WriteLine(warnings.RainStart);
                Console.WriteLine(warnings.RainEnd);
            }
            //Tornado
            Console.WriteLine("Tornado");
            if (warnings.Tornado > 0)
            {
                Console.WriteLine(warnings.TornadoStart);
                Console.WriteLine(warnings.TornadoEnd);
            }
        }

        [Test]
        public async Task GetCityThunderstormTest()
        {
            var api = await BurzeApiWrapper.Factory(_configuration["api_key"]);
            var city = await api.GetCity("Ostrowiec Swietokrzyski");
            Thunderstorm thunder = await api.GetCityThunderstorm(city);
            Console.WriteLine($"Count: {thunder.Count}, Direction {thunder.Direction}, Distance {thunder.Distance}, Period {thunder.Period}");
        }
    }
}