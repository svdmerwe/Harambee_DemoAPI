using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLibrary.Test
{
    public class SimpleTest
    {
        [Theory]
        [InlineData(2,3,5)]
        public void AddNumbers_ShouldWork(int x, int y, int expected)
        {
            //Arrange 

            //Act
            var actual = x + y;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 10)]
        public void AddNumbers_ShouldFail(int x, int y, int expected)
        {
            //Arrange 

            //Act
            var actual = x + y;

            //Assert
            Assert.NotEqual(expected, actual);
        }
    }
}
