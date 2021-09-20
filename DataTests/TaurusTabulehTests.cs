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
    /// Unit tests for TaurusTabuleh class
    /// </summary>
    public class TaurusTabulehTests
    {
        /// <summary>
        /// Checks that the default size is set to Size.small
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            TaurusTabuleh tt = new TaurusTabuleh();
            Assert.Equal(Size.Small, tt.Size);
        }

        /// <summary>
        /// Checks that the size can be changed
        /// </summary>
        /// <param name="size">Size enum value</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            TaurusTabuleh tt = new TaurusTabuleh();
            tt.Size = size;
            Assert.Equal(size, tt.Size);
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
            TaurusTabuleh tt = new TaurusTabuleh();
            tt.Size = size;
            Assert.Equal(price, tt.Price);
        }

        /// <summary>
        /// Checks that the calories are correct for the size
        /// </summary>
        /// <param name="size">Size enum value</param>
        /// <param name="calories">uint for calories</param>
        [Theory]
        [InlineData(Size.Large, 248)]
        [InlineData(Size.Medium, 186)]
        [InlineData(Size.Small, 124)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            TaurusTabuleh tt = new TaurusTabuleh();
            tt.Size = size;
            Assert.Equal(calories, tt.Calories);
        }
    }
}
