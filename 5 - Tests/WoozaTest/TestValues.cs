using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace WoozaTest
{
    public class TestValues
    {
        private readonly TestContext _testContext;
        public TestValues()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Values_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/Plano");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Values_GetById_ValuesReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/Plano/5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Values_GetById_ReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/Plano/XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Values_GetById_CorrectContentType()
        {
            var response = await _testContext.Client.GetAsync("/api/Plano/5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
        }
    }
}
