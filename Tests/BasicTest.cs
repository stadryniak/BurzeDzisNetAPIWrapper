using System.IO;
using System.Threading.Tasks;
using BurzeDzisAPIWrapper;
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
            Assert.DoesNotThrowAsync(async () => await api.GetCity("Ostrowiec Swietokrzyski".ToLower()));
        }
    }
}