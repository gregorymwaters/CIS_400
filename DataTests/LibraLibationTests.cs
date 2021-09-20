using System;
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
    /// Unit tests for LibraLibation class
    /// </summary>
    public class LibraLibationTests
    {
        /// <summary>
        /// Checks that Sparkling defaults to true
        /// </summary>
        [Fact]
        public void ShouldDefaultToSparkling()
        {
            LibraLibation ll = new LibraLibation();
            Assert.True(ll.Sparkling);
        }

        /// <summary>
        /// Checks that it's possible to assign Sparkling property
        /// </summary>
        /// <param name="sparkling"></param>
        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ShouldBeAbleToSetSparkling(bool sparkling)
        {
            LibraLibation ll = new LibraLibation();
            ll.Sparkling = sparkling;
            Assert.Equal(sparkling, ll.Sparkling);
        }

        /// <summary>
        /// Checks that Flavor is assignable
        /// </summary>
        /// <param name="flavor"></param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral)]
        [InlineData(LibraLibationFlavor.Orangeade)]
        [InlineData(LibraLibationFlavor.PinkLemonada)]
        [InlineData(LibraLibationFlavor.SourCherry)]
        public void ShouldBeAbleToSetFlavor(LibraLibationFlavor flavor)
        {
            LibraLibation ll = new LibraLibation();
            ll.Flavor = flavor;
            Assert.Equal(flavor, ll.Flavor);
        }

        /// <summary>
        /// Checks that correct price is returned by flavor
        /// </summary>
        /// <param name="flavor"></param>
        /// <param name="price"></param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, 1.00)]
        [InlineData(LibraLibationFlavor.Orangeade, 1.00)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 1.00)]
        [InlineData(LibraLibationFlavor.SourCherry, 1.00)]
        public void PriceShouldBeCorrectForFlavor(LibraLibationFlavor flavor, decimal price)
        {
            LibraLibation ll = new LibraLibation();
            ll.Flavor = flavor;
            Assert.Equal(price, ll.Price);
        }

        /// <summary>
        /// Checks that correct calories are returned by flavor
        /// </summary>
        /// <param name="flavor"></param>
        /// <param name="price"></param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, 120)]
        [InlineData(LibraLibationFlavor.Orangeade, 180)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 41)]
        [InlineData(LibraLibationFlavor.SourCherry, 100)]
        public void CaloriesShouldBeCorrectForFlavor(LibraLibationFlavor flavor, uint calories)
        {
            LibraLibation ll = new LibraLibation();
            ll.Flavor = flavor;
            Assert.Equal(calories, ll.Calories);
        }

        /// <summary>
        /// Checks that correct name is returned based on Sparkling bool and LibraLibationFlavor enum
        /// </summary>
        /// <param name="flavor">LibraLibationFlavor enum value</param>
        /// <param name="sparkling">Boolean property of LibraLibation</param>
        /// <param name="expected">String of expected value of Name property</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, true, "Sparkling Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, true, "Sparkling Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, true, "Sparkling Pink Lemonada Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, true, "Sparkling Sour Cherry Libra Libation")]
        [InlineData(LibraLibationFlavor.Biral, false, "Still Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, false, "Still Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, false, "Still Pink Lemonada Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, false, "Still Sour Cherry Libra Libation")]
        public void NameShouldBeCorrectForFlavorAndSparkling(LibraLibationFlavor flavor, bool sparkling, string expected)
        {
            LibraLibation ll = new LibraLibation();
            ll.Flavor = flavor;
            ll.Sparkling = sparkling;
            Assert.Equal(expected, ll.Name);
        }


    }
}
