using System;
using Xunit;
using articulate.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace tests
{
    public class TestArticulateController
    {
        private ArticulateController articulateController;
        private Mock<HttpClient> httpClient;
        private readonly ILogger<ArticulateController> _logger;
        private Mock<Random> mockRandom;
        public TestArticulateController()
        {
            articulateController = new ArticulateController(_logger);
            httpClient = new Mock<HttpClient>();
        }
        [Fact]
        public void TestGet()
        {
            // Arrange
            // Task<string> categories = new Task<string>("Person");
            // httpClient.Setup(h => h.GetStringAsync("")).Returns(categories);

            // Task<string> numbers = new Task<string>("Person");
            // httpClient.Setup(h => h.GetStringAsync("")).Returns(numbers);

            //Act 
            var result = "";//ArticulateController.Get().Value;

            // Assert
            Assert.Equal("Martin Luther King", result);

        }
    }
}
