using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Abstract base class for all Gyro type Entree objects on the menu
    /// Inherits from Entree base class
    /// </summary>
    public abstract class Gyro : Entree
    {
        /// <summary>
        /// Special Instructions All Ingredients
        /// All getters and setters inherited from this class have private backing variables
        /// in the child class objects
        /// </summary>
        public abstract bool Pita { get; set; }
        public abstract bool Tomato { get; set; }
        public abstract bool Onion { get; set; }
        public abstract bool Lettuce { get; set; }
        public abstract bool Tzatziki { get; set; }
        public abstract bool Peppers { get; set; }
        public  abstract bool WingSauce { get; set; }
        public  abstract bool Eggplant { get; set; }
        public abstract bool MintChutney { get; set; }
        public abstract DonerMeat Meat { get; set; }
    }
}
