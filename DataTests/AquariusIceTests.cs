using System;
using Xunit;
using System.Collections.Generic;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AquariusIce
    /// </summary>
    public class AquariusIceTests
    {
        [Fact]
        public void DefaultChicken()
        {
            var side = new AresFries();
            Assert.Equal(Size.Small, side.Size);
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
            var side1 = new GeminiStuffedGrapeLeaves();
            Assert.Equal(Size.Small, side1.Size);
            var side2 = new SagittariusGreekSalad();
            Assert.Equal(Size.Small, side2.Size);
            var side3 = new TarusTabuleh();
            Assert.Equal(Size.Small, side3.Size);
            var gyro = new VirgoClassicGyro();
            Assert.True(gyro.Calories == 593);
            Assert.Equal(DonerMeat.Pork, gyro.Meat);
            Assert.Empty(gyro.SpecialInstructions);
            gyro.Onion = false;
            Assert.NotEmpty(gyro.SpecialInstructions);
            Assert.IsAssignableFrom<IEnumerable<string>>(gyro.SpecialInstructions);
            var fish = new PicesFishDish();
        }
        /// <summary>
        /// Checks default flavor
        /// </summary>
        [Fact]
        public void FlavorShouldDefaultToLemon()
        {
            var ice = new AquariusIce();
            Assert.Equal(AquariusIceFlavor.Lemon, ice.Flavor);
        }

        /// <summary>
        /// Checks that the <paramref name="flavor"/> can be set
        /// </summary>
        /// <param name="flavor">The flavor to use</param>
        [Theory]
        [InlineData(AquariusIceFlavor.BlueRaspberry)]
        [InlineData(AquariusIceFlavor.Lemon)]
        [InlineData(AquariusIceFlavor.Mango)]
        [InlineData(AquariusIceFlavor.Orange)]
        [InlineData(AquariusIceFlavor.Strawberry)]
        [InlineData(AquariusIceFlavor.Watermellon)]
        public void ShouldBeAbleToSetFlavor(AquariusIceFlavor flavor)
        {
            var ice = new AquariusIce();
            ice.Flavor = flavor;
            Assert.Equal(flavor, ice.Flavor);
        }

        /// <summary>
        /// Checks the default size
        /// </summary>
        [Fact]
        public void ShouldDefaultToSmall()
        {
            var ice = new AquariusIce();
            Assert.Equal(Size.Small, ice.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 2.0)]
        [InlineData(Size.Medium, 2.5)]
        [InlineData(Size.Large, 3.0)]
        public void ShouldHaveTheRightPriceForSize(Size size, decimal price)
        {
            var ice = new AquariusIce()
            {
                Size = size
            };
            Assert.Equal(price, ice.Price);

        }


    }
}
