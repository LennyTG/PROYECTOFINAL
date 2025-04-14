using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace WebApp.IntegrationTest
{
    public class IntegrationTestWeb : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public IntegrationTestWeb(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task TestHomePage()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Test404ErrorPage()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/non-existent-page");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
