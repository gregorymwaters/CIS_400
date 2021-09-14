using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// Class definition for Cancer Havleh Cake
    /// Inherits from Treat
    /// </summary>
    public class CancerHalvehCake : Treat
    {
        /// <summary>
        /// Override method for Calories inherited from Treat base class
        /// </summary>
        public override uint Calories { get { return 272; } }
        /// <summary>
        /// Override method for getting Price inherited from Treat base class
        /// </summary>
        public override decimal Price { get { return 3.00m; } }
    }
}
