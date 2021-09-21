using System;
using System.Linq;
using Xunit;
using System.Collections.Generic;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Drinks;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for CapricornMountainTea class
    /// </summary>
    public class CapricornMountainTeaTests
    {
        /// <summary>
        /// Checks that the correct price is returned
        /// </summary>
        /// <param name="honey">boolean representing Honey</param>
        /// <param name="price">decimal representing expected price</param>
        [Theory]
        [InlineData(false, 2.50)]
        [InlineData(true, 2.50)]
        public void PriceShouldBeCorrectForHoney(bool honey, decimal price)
        {
            CapricornMountainTea cmt = new CapricornMountainTea();
            cmt.Honey = honey;
            Assert.Equal(price, cmt.Price);
            
        }

        /// <summary>
        /// Checks that the correct calories are returned
        /// </summary>
        /// <param name="honey">boolean representing Honey</param>
        /// <param name="calories">uint representing expected calories</param>
        [Theory]
        [InlineData(false, 0)]
        [InlineData(true, 64)]
        public void CaloriesShouldBeCorrectForHoney(bool honey, uint calories)
        {
            CapricornMountainTea cmt = new CapricornMountainTea();
            cmt.Honey = honey;
            Assert.Equal(calories, cmt.Calories);
        }
    }
}
