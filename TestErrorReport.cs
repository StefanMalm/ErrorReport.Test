using ErrorReportApi;
using ErrorReportApi.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ErrorReport.Test
{
    public class TestErrorReport
    {
        private WebApplicationFactory<Program> _webAppFactory;
        private HttpClient _httpClient;

        public TestErrorReport()
        {
            _webAppFactory = new WebApplicationFactory<ErrorReportApi.Program>();
            _httpClient = _webAppFactory.CreateDefaultClient();
        }

        [Fact]
        public async Task GetReportsFromDatabase()
        {
            var response = await _httpClient.GetAsync("https://localhost:7144/api/Reports");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}