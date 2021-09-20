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
    /// Unit tests for GeminiStuffedFrapeLeaves class
    /// </summary>
    public class GeminiStuffedGrapeLeavesTests
    {
        /// <summary>
        /// Checks that the default size is set to Size.small
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            GeminiStuffedGrapeLeaves gsg = new GeminiStuffedGrapeLeaves();
            Assert.Equal(Size.Small, gsg.Size);
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
            GeminiStuffedGrapeLeaves gsg = new GeminiStuffedGrapeLeaves();
            gsg.Size = size;
            Assert.Equal(size, gsg.Size);
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
            GeminiStuffedGrapeLeaves gsg = new GeminiStuffedGrapeLeaves();
            gsg.Size = size;
            Assert.Equal(price, gsg.Price);
        }

        /// <summary>
        /// Checks that the calories are correct for the size
        /// </summary>
        /// <param name="size">Size enum value</param>
        /// <param name="calories">uint for calories</param>
        [Theory]
        [InlineData(Size.Large, 720)]
        [InlineData(Size.Medium, 540)]
        [InlineData(Size.Small, 360)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            GeminiStuffedGrapeLeaves gsg = new GeminiStuffedGrapeLeaves();
            gsg.Size = size;
            Assert.Equal(calories, gsg.Calories);
        }
    }
}
