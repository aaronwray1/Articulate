using System;
using Xunit;
using categories.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;


namespace tests
{
    public class TestCategoriesContoller
    {
        private CategoriesController categoriesController;
        private readonly ILogger<CategoriesController> _logger;

        private Mock<Random> mockRandom;
        public TestCategoriesContoller()
        {
            categoriesController = new CategoriesController(_logger);
            mockRandom = new Mock<Random>();
        }

        [Fact]
        public void TestGet()
        {
            // Arrange
            mockRandom.Setup(m => m.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(2);

            // //Act 
            var result = categoriesController.Get();

            // // Assert
            Assert.Equal("Random", result);

        }
    }
}
