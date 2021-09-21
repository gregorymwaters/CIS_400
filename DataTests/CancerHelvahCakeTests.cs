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
    /// Unit tests for CancerHelvahCake class
    /// </summary>
    public class CancerHelvahCakeTests
    {
        /// <summary>
        /// Checks that the correct Calories are returned
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            CancerHalvehCake chc = new CancerHalvehCake();
            Assert.Equal(3.00m, chc.Price);
        }

        /// <summary>
        /// Checks that the correct Price is returned
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            CancerHalvehCake chc = new CancerHalvehCake();
            Assert.Equal(272u, chc.Calories);
        }
    }
}
