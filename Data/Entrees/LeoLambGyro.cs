using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    public class LeoLambGyro
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 
        private DonerMeat meat = DonerMeat.Lamb;


        /// <summary>
        /// Special instructions backing variables
        /// </summary>
        private bool pita = true;
        private bool tomato = true;
        private bool onion = true;
        private bool lettuce = true;
        private bool eggplant = true;
        private bool mintChutney = true;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Price of Leo Lamb Gyro
        /// </summary>
        public decimal Price
        {
            get { return 5.75m; }
        }

        public bool Pita { get { return pita; } set { pita = value; } }
        public bool Tomato { get { return tomato; } set { tomato = value; } }
        public bool Onion { get { return onion; } set { onion = value; } }
        public bool Lettuce { get { return lettuce; } set { lettuce = value; } }
        public bool Eggplant { get { return eggplant; } set { eggplant = value; } }
        public bool MintChutney { get { return mintChutney; } set { mintChutney = value; } }

        /// <summary>
        /// The Calories of Leo Lamb Gyro
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                switch (meat)
                {
                    case DonerMeat.Beef:
                        calories = 181;
                        break;
                    case DonerMeat.Chicken:
                        calories = 113;
                        break;
                    case DonerMeat.Lamb:
                        calories = 151;
                        break;
                    case DonerMeat.Pork:
                        calories = 187;
                        break;
                }
                if (pita) calories += 262;
                if (tomato) calories += 30;
                if (onion) calories += 30;
                if (lettuce) calories += 54;
                if (eggplant) calories += 47;
                if (mintChutney) calories += 10;
                return calories;
            }
        }


        /// <summary>
        /// The Meat choice of Leo Lamb Gyro
        /// </summary>
        public DonerMeat Meat { get { return meat; } set { meat = value; } }


        /// <summary>
        /// The SpecialInstructions of Leo Lamb Gyro
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!pita) specialInstructions.Add("Hold Pita");
                if (!tomato) specialInstructions.Add("Hold Tomato");
                if (!onion) specialInstructions.Add("Hold Onion");
                if (!lettuce) specialInstructions.Add("Hold Lettuce");
                if (!eggplant) specialInstructions.Add("Hold Eggplant");
                if (!mintChutney) specialInstructions.Add("Hold Mint Chutney");

                switch (meat)
                {
                    case DonerMeat.Beef:
                        specialInstructions.Add("Use Beef");
                        break;
                    case DonerMeat.Pork:
                        specialInstructions.Add("Use Pork");
                        break;
                    case DonerMeat.Chicken:
                        specialInstructions.Add("Use Chicken");
                        break;
                    default:
                        break;
                }
                return specialInstructions;
            }
        }
    }
}
