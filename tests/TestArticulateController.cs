using System;
using Xunit;
using articulate.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Collections.Generic;
using RichardSzalay.MockHttp;
using Microsoft.AspNetCore.Mvc;

namespace tests
{
    public class TestArticulateController
    {
        private ArticulateController articulateController;
        private readonly ILogger<ArticulateController> _logger;
        public TestArticulateController()
        {
        }

        [Fact]
        public async void TestGetPerson()
        {
            // Arrange
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://categories:81/categories")
                .Respond("text/plain", "Person");
            mockHttp.When("http://numbers:82/numbers")
                .Respond("text/plain", "5");
            var client = new HttpClient(mockHttp);
            articulateController = new ArticulateController(_logger, client, "../../../../articulate/articulate.csv");

            //Act 
            var response = await articulateController.Get();
            string result = (string)((OkObjectResult)response).Value;

            // Assert
            Assert.Equal("Martin Luther King", result);

        }

        [Fact]

        public async void TestGetRandom()
        {
            // Arrange
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://categories:81/categories")
                .Respond("text/plain", "Random");
            mockHttp.When("http://numbers:82/numbers")
                .Respond("text/plain", "5");
            var client = new HttpClient(mockHttp);
            articulateController = new ArticulateController(_logger, client, "../../../../articulate/articulate.csv");

            //Act 
            var response = await articulateController.Get();
            string result = (string)((OkObjectResult)response).Value;

            // Assert
            Assert.Equal("Aguaymanto Sour", result);

        }

        [Fact]

        public async void TestGetAction()
        {
            // Arrange
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://categories:81/categories")
                .Respond("text/plain", "Action");
            mockHttp.When("http://numbers:82/numbers")
                .Respond("text/plain", "100");
            var client = new HttpClient(mockHttp);
            articulateController = new ArticulateController(_logger, client, "../../../../articulate/articulate.csv");

            //Act 
            var response = await articulateController.Get();
            string result = (string)((OkObjectResult)response).Value;

            // Assert
            Assert.Equal("embalm", result);

        }

        [Fact]

        public async void TestGetWorld()
        {
            // Arrange
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://categories:81/categories")
                .Respond("text/plain", "World");
            mockHttp.When("http://numbers:82/numbers")
                .Respond("text/plain", "1");
            var client = new HttpClient(mockHttp);
            articulateController = new ArticulateController(_logger, client, "../../../../articulate/articulate.csv");

            //Act 
            var response = await articulateController.Get();
            string result = (string)((OkObjectResult)response).Value;

            // Assert
            Assert.Equal("Los Angeles", result);

        }

        [Fact]

        public async void TestGetNature()
        {
            // Arrange
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://categories:81/categories")
                .Respond("text/plain", "Nature");
            mockHttp.When("http://numbers:82/numbers")
                .Respond("text/plain", "1");
            var client = new HttpClient(mockHttp);
            articulateController = new ArticulateController(_logger, client, "../../../../articulate/articulate.csv");

            //Act 
            var response = await articulateController.Get();
            string result = (string)((OkObjectResult)response).Value;

            // Assert
            Assert.Equal("mountain goat", result);

        }

        [Fact]

        public async void TestGetObject()
        {
            // Arrange
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.When("http://categories:81/categories")
                .Respond("text/plain", "Object");
            mockHttp.When("http://numbers:82/numbers")
                .Respond("text/plain", "100");
            var client = new HttpClient(mockHttp);
            articulateController = new ArticulateController(_logger, client, "../../../../articulate/articulate.csv");

            //Act 
            var response = await articulateController.Get();
            string result = (string)((OkObjectResult)response).Value;

            // Assert
            Assert.Equal("camera", result);

        }
    }
}
