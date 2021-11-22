using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLibrary.Test
{
    public class ValidateProductTest
    {
        private readonly IProductProcessor _productProcessor;

        public ValidateProductTest()
        {
            ProductProcessor productProcessor = new ProductProcessor();
            _productProcessor = productProcessor;
        }

        [Fact]
        public void ValidateProductTest_ShouldBeValid()
        {
            
            //Arrange
            Product testProdut = new Product {
                Id = 1,
                Category = "Electronic",
                Name = "Head Set",
                Price = 50
            };

            //Act
            var actualProduct = _productProcessor.ValidateProduct(testProdut);

            //Assert
            Assert.True(!string.IsNullOrWhiteSpace(actualProduct.Name));
            Assert.True(!string.IsNullOrWhiteSpace(actualProduct.Category));
            Assert.True(actualProduct.Price > 0);
        }

        [Fact]
        public void ValidateProductTest_NullReferenceException()
        {
            //Arrange
            Product testProduct = null;

            //Assert
            Assert.Throws<NullReferenceException>(() => _productProcessor.ValidateProduct(testProduct));
        }

    }
}
