using System;
using Xunit;
using numbers.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using random;

namespace tests
{
    public class TestNumbersController
    {
        private NumbersController numbersController;
        private readonly ILogger<NumbersController> _logger;
        private Mock<RandomGenerator> mockRandom;
        public TestNumbersController()
        {

        }
        [Fact]
        public void TestGet()
        {
            // Arrange
            mockRandom = new Mock<RandomGenerator>();
            mockRandom.Setup(m => m.Generate(It.IsAny<int>(), It.IsAny<int>())).Returns(8);
            numbersController = new NumbersController(_logger, mockRandom.Object);

            //Act 
            var result = numbersController.Get();

            // Assert
            Assert.Equal(8, result);

        }
    }
}
