using AppDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace AppTests
{
    public class Tests
    {
        [Test]
        public async Task CallingChuckNorrisApiService_ReturnsCorrectDataType()
        {
           

            var chuckNorrisApi = new ChuckNorrisApiService();


            var result = await chuckNorrisApi.GetApiData();

            Assert.That(result, Is.TypeOf<string>());


        }

        [Test]
        public async Task CallingChuckNorrisApiService_ReturnsCorrectStatusCode()
        {
            var chuckNorrisApi = new ChuckNorrisApiService();
            bool expected = true;

            var result = await chuckNorrisApi.Response();

            Assert.That(result.IsSuccessStatusCode, Is.EqualTo(expected));


        }

    }
}