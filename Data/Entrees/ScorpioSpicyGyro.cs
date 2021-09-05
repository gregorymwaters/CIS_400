using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    public class ScorpioSpicyGyro
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 
        private DonerMeat meat = DonerMeat.Chicken;


        /// <summary>
        /// Special instructions backing variables
        /// </summary>
        private bool pita = true;
        private bool onion = true;
        private bool lettuce = true;
        private bool peppers = true;
        private bool wingSauce = true;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Price of Virgo Classic Gyro
        /// </summary>
        public decimal Price
        {
            get { return 6.20m; }
        }

        public bool Pita { get { return pita; } set { pita = value; } }
        public bool Onion { get { return onion; } set { onion = value; } }
        public bool Lettuce { get { return lettuce; } set { lettuce = value; } }
        public bool Peppers { get { return peppers; } set { peppers = value; } }
        public bool WingSauce { get { return wingSauce; } set { wingSauce = value; } }

        /// <summary>
        /// The Calories of Virgo Classic Gyro
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
                if (onion) calories += 30;
                if (lettuce) calories += 54;
                if (peppers) calories += 33;
                if (wingSauce) calories += 15;
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
                if (!onion) specialInstructions.Add("Hold Onion");
                if (!lettuce) specialInstructions.Add("Hold Lettuce");
                if (!peppers) specialInstructions.Add("Hold Peppers");
                if (!wingSauce) specialInstructions.Add("Hold Wing Sauce");

                switch (meat)
                {
                    case DonerMeat.Beef:
                        specialInstructions.Add("Use Beef");
                        break;
                    case DonerMeat.Pork:
                        specialInstructions.Add("Use Pork");
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
