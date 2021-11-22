using EFDataAccessLibrary.DataProcessors;
using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLibrary.Test
{
    public class ValidateDiscountTest
    {
        [Fact]
        public void ValidateDiscount_ShouldApplyDiscount()
        {
            //Arrange
            Order newOrder = new Order
            {
                Id = 1,
                CustomerId = 1,
                Basket = new Basket
                {
                    Id = 1,
                    Total = 48,
                    BasketItems = new List<BasketItems>()
                    {
                        new BasketItems {Id=1, Category="Electronic", Name="Camera", Price=50, ProductId = 2 },
                        new BasketItems {Id=1, Category="Accessories", Name="Strap", Price=20, ProductId = 6 }
                    }
                }
            };

            //Act
            Order order = new Order
            {
                Id = 1,
                CustomerId = 1,
                Basket = new Basket
                {
                    Id = 1,
                    Total = 60,
                    BasketItems = new List<BasketItems>()
                    {
                        new BasketItems {Id=1, Category="Electronic", Name="Camera", Price=50, ProductId = 2 },
                        new BasketItems {Id=1, Category="Accessories", Name="Strap", Price=20, ProductId = 6 }
                    }
                }
            };

            var actual = OrderProcessor.CheckIfDiscountApplied(order, newOrder);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void ValidateDiscount_ShouldFailWithNullObject()
        {
            Order order = null;
            Order newOrder = null;

            Assert.Throws<NullReferenceException>(() => OrderProcessor.CheckIfDiscountApplied(order, newOrder));
        }
    }
}
