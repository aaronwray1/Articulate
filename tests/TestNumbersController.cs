using System;
using Xunit;
using numbers.Controllers;
using Moq;
using Microsoft.Extensions.Logging;


namespace tests
{
    public class TestNumbersController
    {
        private NumbersController numbersController;
        private readonly ILogger<NumbersController> _logger;
        private Mock<Random> mockRandom;
        public TestNumbersController()
        {
            numbersController = new NumbersController(_logger);
            mockRandom = new Mock<Random>();
        }
        [Fact]
        public void TestGet()
        {
            // Arrange
            mockRandom.Setup(m => m.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(8);

            //Act 
            var result = numbersController.Get();

            // Assert
            Assert.Equal(8, result);

        }
    }
}
