using System;
using Xunit;
using categories.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using random;

namespace tests
{
    public class TestCategoriesContoller
    {
        private CategoriesController categoriesController;
        private readonly ILogger<CategoriesController> _logger;

        private Mock<RandomGenerator> mockRandom;
        public TestCategoriesContoller()
        {

        }

        [Fact]
        public void TestGet()
        {
            // Arrange
            mockRandom = new Mock<RandomGenerator>();
            mockRandom.Setup(m => m.Generate(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
            categoriesController = new CategoriesController(_logger, mockRandom.Object);

            // //Act 
            var result = categoriesController.Get();

            // // Assert
            Assert.Equal("Random", result);

        }
    }
}
