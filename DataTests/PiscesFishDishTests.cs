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
    /// Unit test for PicesFishDish class
    /// </summary>
    public class PiscesFishDishTests
    {
        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            PiscesFishDish pc = new PiscesFishDish();
            Assert.Equal(5.99m, pc.Price);
        }

        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            PiscesFishDish pc = new PiscesFishDish();
            uint tempCal = 726;
            Assert.Equal(tempCal, pc.Calories);
        }

        /// <summary>
        /// Checks to ensure that SpecialInstructions is empty
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeEmpty()
        {
            PiscesFishDish pc = new PiscesFishDish();
            Assert.Empty(pc.SpecialInstructions);
        }
    }
}
