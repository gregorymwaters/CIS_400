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
    /// Unit tests for VirgoClassicGyro
    /// </summary>
    public class VirgoClassicGyroTests
    {
        /// <summary>
        /// Checks that default ingredients are set correctly
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            VirgoClassicGyro vcg = new VirgoClassicGyro();
            Assert.True(vcg.Pita);
            Assert.True(vcg.Tomato);
            Assert.True(vcg.Onion);
            Assert.True(vcg.Lettuce);
            Assert.True(vcg.Tzatziki);
            Assert.False(vcg.Peppers);
            Assert.False(vcg.MintChutney);
            Assert.False(vcg.WingSauce);
            Assert.False(vcg.Eggplant);
            Assert.Equal(DonerMeat.Pork, vcg.Meat);
        }

        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Entree vcg = new VirgoClassicGyro();
            Assert.Equal(5.50m, vcg.Price);
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
            VirgoClassicGyro vcg = new VirgoClassicGyro();
            vcg.Meat = meat;
            vcg.Pita = pita;
            vcg.Tomato = tomato;
            vcg.Peppers = peppers;
            vcg.Eggplant = eggplant;
            vcg.Onion = onion;
            vcg.Lettuce = lettuce;
            vcg.Tzatziki = tzatsiki;
            vcg.WingSauce = wingsuace;
            vcg.MintChutney = mintchutney;
            Assert.Equal(calories, vcg.Calories);
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
        //Default for VirgoClassic
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, false, new string[] { })]
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, false, false, new string[] {"Hold Pita"})]
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, true, false, new string[] { "Hold Pita", "Add Wing Sauce" })]
        [InlineData(DonerMeat.Beef, false, true, false, false, true, true, true, true, false, new string[] { "Hold Pita", "Add Wing Sauce", "Use Beef" })]
        [InlineData(DonerMeat.Beef, false, true, false, true, true, true, true, true, false, new string[] { "Hold Pita",  "Add Eggplant", "Add Wing Sauce", "Use Beef" })]
        [InlineData(DonerMeat.Chicken, false, true, false, true, true, true, true, true, false, new string[] { "Hold Pita",  "Add Eggplant", "Add Wing Sauce", "Use Chicken" })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, true, true, false, new string[] { "Hold Pita",  "Add Eggplant", "Add Wing Sauce", "Use Lamb" })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, false, true, true, true, false, new string[] { "Hold Pita", "Hold Onion", "Add Eggplant", "Add Wing Sauce", "Use Lamb" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatsiki, bool wingsuace, bool mintchutney, string[] expected)
        {
            VirgoClassicGyro vcg = new VirgoClassicGyro();
            vcg.Meat = meat;
            vcg.Pita = pita;
            vcg.Tomato = tomato;
            vcg.Peppers = peppers;
            vcg.Eggplant = eggplant;
            vcg.Onion = onion;
            vcg.Lettuce = lettuce;
            vcg.Tzatziki = tzatsiki;
            vcg.WingSauce = wingsuace;
            vcg.MintChutney = mintchutney;
            Assert.Equal(expected, vcg.SpecialInstructions.ToArray());
        }
    }
}
