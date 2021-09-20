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
    /// Unit tests for SagittariusGreekSalad class
    /// </summary>
    public class SagittariusGreekSaladTests
    {
        /// <summary>
        /// Checks that the default size is set to Size.small
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            SagittariusGreekSalad sgs = new SagittariusGreekSalad();
            Assert.Equal(Size.Small, sgs.Size);
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
            SagittariusGreekSalad sgs = new SagittariusGreekSalad();
            sgs.Size = size;
            Assert.Equal(size, sgs.Size);
        }

        /// <summary>
        /// Checks that the prices changes with size
        /// </summary>
        /// <param name="size">Size enum value</param>
        /// <param name="price">decimal for the price</param>
        [Theory]
        [InlineData(Size.Large, 3.00)]
        [InlineData(Size.Medium, 2.50)]
        [InlineData(Size.Small, 2.00)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            SagittariusGreekSalad sgs = new SagittariusGreekSalad();
            sgs.Size = size;
            Assert.Equal(price, sgs.Price);
        }

        /// <summary>
        /// Checks that the calories are correct for the size
        /// </summary>
        /// <param name="size">Size enum value</param>
        /// <param name="calories">uint for calories</param>
        [Theory]
        [InlineData(Size.Large, 360)]
        [InlineData(Size.Medium, 270)]
        [InlineData(Size.Small, 180)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            SagittariusGreekSalad sgs = new SagittariusGreekSalad();
            sgs.Size = size;
            Assert.Equal(calories, sgs.Calories);
        }
    }
}
