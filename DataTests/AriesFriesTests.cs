using System;
using System.Linq;
using Xunit;
using System.Collections.Generic;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AriesFries class
    /// </summary>
    public class AriesFriesTests
    {
        /// <summary>
        /// Checks that the class defaults to Size.small
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            AriesFries af = new AriesFries();
            Assert.Equal(Size.Small, af.Size);
        }

        /// <summary>
        /// Checks that the size can be set
        /// </summary>
        /// <param name="size">Size enum</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            AriesFries af = new AriesFries();
            af.Size = size;
            Assert.Equal(size, af.Size);
        }

        /// <summary>
        /// Checks that the prices changes with size
        /// </summary>
        /// <param name="size">Size enum value</param>
        /// <param name="price">decimal for the price</param>
        [Theory]
        [InlineData(Size.Large, 2.50)]
        [InlineData(Size.Medium, 2.00)]
        [InlineData(Size.Small, 1.50)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            AriesFries af = new AriesFries();
            af.Size = size;
            Assert.Equal(price, af.Price);
        }

        /// <summary>
        /// Checks that the calories are correct for the size
        /// </summary>
        /// <param name="size">Size enum value</param>
        /// <param name="calories">uint for calories</param>
        [Theory]
        [InlineData(Size.Large, 608)]
        [InlineData(Size.Medium, 456)]
        [InlineData(Size.Small, 304)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            AriesFries af = new AriesFries();
            af.Size = size;
            Assert.Equal(calories, af.Calories);
        }
    }
}
