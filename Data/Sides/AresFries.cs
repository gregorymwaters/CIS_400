using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    public class AriesFries : Side
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 

        /// <summary>
        /// The default Size of Ares Fries
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Size of Ares Fries
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The Price of Ares Fries
        /// </summary>
        public override decimal Price
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
        /// The Calories of Ares Fries
        /// </summary>

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 304;
                    case Size.Medium:
                        return 456;
                    case Size.Large:
                        return 608;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
