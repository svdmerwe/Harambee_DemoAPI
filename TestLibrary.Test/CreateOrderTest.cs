using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.DataProcessors;
using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLibrary.Test
{
    public class CreateOrderTest
    {
        private readonly DemoDataContext _context;
        public CreateOrderTest(DemoDataContext context)
        {
            _context = context;
        }

        [Fact]
        public void CreateOrder_ShouldCreateOrderWithDiscount()
        {           
            Order newOrder = new Order
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
            //Arrange

            //Act
            Order actualOrder = OrderProcessor.CreateOrder(newOrder, _context);

            //Assert
            Assert.True(actualOrder.Basket.Total != 60);
        }
    }
}
