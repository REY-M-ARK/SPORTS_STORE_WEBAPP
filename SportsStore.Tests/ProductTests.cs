using Xunit;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Can_Create_Product()
        {
            // Arrange
            Product p = new Product
            {
                Name = "Test Product",
                Price = 100
            };

            // Act
            var result = p.Name;

            // Assert
            Assert.Equal("Test Product", result);
        }
    }
}