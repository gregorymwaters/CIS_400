using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    public class VirgoClassicGyro
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 

        private DonerMeat meat = DonerMeat.Pork;


        /// <summary>
        /// Special instructions backing variables
        /// </summary>
        private bool pita = true;
        private bool tomato = true;
        private bool onion = true;
        private bool lettuce = true;
        private bool tzatziki = true;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Price of Virgo Classic Gyro
        /// </summary>
        public decimal Price
        {
            get { return 5.50m; }
        }

        public bool Pita { get { return pita; } set { pita = value; } }
        public bool Tomato { get { return tomato; } set { tomato = value; } }
        public bool Onion { get { return onion; } set { onion = value; } }
        public bool Lettuce { get { return lettuce; } set { lettuce = value; } }
        public bool Tzatziki { get { return tzatziki; } set { tzatziki = value; } }


        /// <summary>
        /// The Calories of Virgo Classic Gyro
        /// Default is 593
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
                if (tzatziki) calories += 30;
                return calories;
            }
        }

        /// <summary>
        /// The Meat choice of Virgo Classic Gyro
        /// </summary>
        public DonerMeat Meat { get { return meat; } set { meat = value; } }


        /// <summary>
        /// The SpecialInstructions of Virgo Classic Gyro
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
                if (!tzatziki) specialInstructions.Add("Hold Tzatziki");

                switch(meat)
                {
                    case DonerMeat.Beef:
                        specialInstructions.Add("Use Beef");
                        break;
                    case DonerMeat.Chicken:
                        specialInstructions.Add("Use Chicken");
                        break;
                    case DonerMeat.Lamb:
                        specialInstructions.Add("Use Lamb");
                        break;
                    default:
                        break;
                }
                return specialInstructions;
            }
        }
    }
}
