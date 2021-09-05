using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    public class TarusTabuleh
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 

        /// <summary>
        /// The default Size of Tarus Tabuleh
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Size of Tarus Tabuleh
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The Price of Tarus Tabuleh
        /// </summary>
        public decimal Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.50m;
                    case Size.Medium:
                        return 2.00m;
                    case Size.Large:
                        return 2.50m;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The Calories of Tarus Tabuleh
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 124;
                    case Size.Medium:
                        return 186;
                    case Size.Large:
                        return 248;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
