using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Public class for menu item LeoLambGyro inherrites from Gyro parent class
    /// </summary>
    public class LeoLambGyro : Gyro, INotifyPropertyChanged, IMenuItem
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
        private bool peppers = false;
        private bool tzatziki = false;
        private bool wingSauce = false;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Price of Leo Lamb Gyro
        /// </summary>
        public override decimal Price
        {
            get { return 5.75m; }
        }

        public override bool Pita { get { return pita; } set { pita = value; } }
        public override bool Tomato { get { return tomato; } set { tomato = value; } }
        public override bool Onion { get { return onion; } set { onion = value; } }
        public override bool Lettuce { get { return lettuce; } set { lettuce = value; } }
        public override bool Eggplant { get { return eggplant; } set { eggplant = value; } }
        public override bool MintChutney { get { return mintChutney; } set { mintChutney = value; } }
        public override bool Peppers { get { return peppers; } set { peppers = value; } }
        public override bool Tzatziki { get { return tzatziki; } set { tzatziki = value; } }
        public override bool WingSauce { get { return wingSauce; } set { wingSauce = value; } }

        /// <summary>
        /// The Calories of Leo Lamb Gyro
        /// </summary>
        public override uint Calories
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
                if (peppers) calories += 33;
                if (wingSauce) calories += 15;
                if (eggplant) calories += 47;
                if (mintChutney) calories += 10;
                return calories;
            }
        }


        /// <summary>
        /// The Meat choice of Leo Lamb Gyro
        /// </summary>
        public override DonerMeat Meat { get { return meat; } set { meat = value; } }


        /// <summary>
        /// The SpecialInstructions of Leo Lamb Gyro
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
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
                if (tzatziki) specialInstructions.Add("Add Tzatziki");
                if (peppers) specialInstructions.Add("Add Peppers");
                if (wingSauce) specialInstructions.Add("Add Wing Sauce");

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

        public override string Name
        {
            get {return "Leo Lamb Gyro";}
        }
        public override string ToString()
        {
            return "Leo Lamb Gyro";
        }
    }
}
