using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// Class definition for Capricorn Mountain Tea
    /// </summary>
    public class CapricornMountainTea : Drink
    {
        /// <summary>
        /// private backing variable for default setting
        /// </summary>
        private bool honey = false;
        /// <summary>
        /// Overridden getter for price inherited from Drink
        /// </summary>
        public override decimal Price { get { return 2.50m; } }

        /// <summary>
        /// Overridden Calories getter inherited from Drink
        /// </summary>
        public override uint Calories {
            get 
            {
                if(honey)
                {
                    return 64;
                }
                else
                {
                    return 0;
                }
            } 
        }

        /// <summary>
        /// Getter and setter for private backing variable honey
        /// </summary>
        public bool Honey { get { return honey; } set { honey = value; } }
        

    }
}
