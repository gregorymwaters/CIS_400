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
    /// Unit Tests for LeoLambGyro Class
    /// </summary>
    public class LeoLambGyroTests
    {
        /// <summary>
        /// Checks that default ingredients are set correctly
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            LeoLambGyro llg = new LeoLambGyro();
            Assert.True(llg.Pita);
            Assert.True(llg.Tomato);
            Assert.True(llg.Onion);
            Assert.True(llg.Lettuce);
            Assert.False(llg.Tzatziki);
            Assert.False(llg.Peppers);
            Assert.True(llg.MintChutney);
            Assert.False(llg.WingSauce);
            Assert.True(llg.Eggplant);
            Assert.Equal(DonerMeat.Lamb, llg.Meat);
        }

        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Entree llg = new LeoLambGyro();
            Assert.Equal(5.75m, llg.Price);
        }

        /// <summary>
        /// Checks that the calorie calculations are correct
        /// </summary>
        /// <param name="meat">References the DonerMeat enum</param>
        /// <param name="pita">boolean for Pita value=262</param>
        /// <param name="tomato">boolean for Tomato value=30</param>
        /// <param name="peppers">boolean for Peppers value=33</param>
        /// <param name="eggplant">boolean for Eggplant value=47</param>
        /// <param name="onion">boolean for Onion value=30</param>
        /// <param name="lettuce">boolean for Lettuce value=54</param>
        /// <param name="tzatsiki">boolean for Tzatziki value=30</param>
        /// <param name="wingsuace">boolean for Wing Sauce value=15</param>
        /// <param name="mintchutney">boolean for Mint Chutney value=10</param>
        /// <param name="calories">uint for total Calories based on documentation and hand calculation</param>
        [Theory]
        //Default for VirgoClassic
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, false, 593)]
        //Defualt for ScorpioSpicy
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, 507)]
        //Default for LeoLamb
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, 584)]
        //Beef change
        [InlineData(DonerMeat.Beef, true, true, false, false, true, true, true, false, false, 587)]
        //No Tomato
        [InlineData(DonerMeat.Beef, true, false, false, false, true, true, true, false, false, 557)]
        //Add Wing Sauce
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, true, false, 608)]
        //No Pita
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, false, false, 331)]
        //Everything with Pork
        [InlineData(DonerMeat.Pork, true, true, true, true, true, true, true, true, true, 698)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatsiki, bool wingsuace, bool mintchutney, uint calories)
        {
            LeoLambGyro llg = new LeoLambGyro();
            llg.Meat = meat;
            llg.Pita = pita;
            llg.Tomato = tomato;
            llg.Peppers = peppers;
            llg.Eggplant = eggplant;
            llg.Onion = onion;
            llg.Lettuce = lettuce;
            llg.Tzatziki = tzatsiki;
            llg.WingSauce = wingsuace;
            llg.MintChutney = mintchutney;
            Assert.Equal(calories, llg.Calories);
        }

        /// <summary>
        /// Checks that the Special Instruction correctly populates
        /// </summary>
        /// <param name="meat"></param>
        /// <param name="pita"></param>
        /// <param name="tomato"></param>
        /// <param name="peppers"></param>
        /// <param name="eggplant"></param>
        /// <param name="onion"></param>
        /// <param name="lettuce"></param>
        /// <param name="tzatsiki"></param>
        /// <param name="wingsuace"></param>
        /// <param name="mintchutney"></param>
        /// <param name="expected"></param>
        [Theory]
        //Default for LeoLamb
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, new string[] { })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, false, true, new string[] { "Hold Pita" })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, true, true, new string[] { "Hold Pita", "Add Wing Sauce" })]
        [InlineData(DonerMeat.Beef, false, true, false, true, true, true, false, true, true, new string[] { "Hold Pita", "Add Wing Sauce", "Use Beef" })]
        [InlineData(DonerMeat.Beef, false, true, false, false, true, true, false, true, true, new string[] { "Hold Pita", "Hold Eggplant", "Add Wing Sauce", "Use Beef" })]
        [InlineData(DonerMeat.Chicken, false, true, false, false, true, true, true, true, true, new string[] { "Hold Pita", "Hold Eggplant", "Add Tzatziki", "Add Wing Sauce", "Use Chicken" })]
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, true, true, new string[] { "Hold Pita", "Hold Eggplant", "Add Tzatziki", "Add Wing Sauce", "Use Pork" })]
        [InlineData(DonerMeat.Pork, false, true, false, false, false, true, true, true, true, new string[] { "Hold Pita", "Hold Onion", "Hold Eggplant", "Add Tzatziki", "Add Wing Sauce", "Use Pork" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatsiki, bool wingsuace, bool mintchutney, string[] expected)
        {
            LeoLambGyro llg = new LeoLambGyro();
            llg.Meat = meat;
            llg.Pita = pita;
            llg.Tomato = tomato;
            llg.Peppers = peppers;
            llg.Eggplant = eggplant;
            llg.Onion = onion;
            llg.Lettuce = lettuce;
            llg.Tzatziki = tzatsiki;
            llg.WingSauce = wingsuace;
            llg.MintChutney = mintchutney;
            Assert.Equal(expected, llg.SpecialInstructions.ToArray());
        }
    }
}
