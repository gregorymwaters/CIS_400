using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    public class SagittariusGreekSalad : Side
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 

        /// <summary>
        /// The default Size of Sagittarius Greek Salad
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Size of Sagittarius Greek Salad
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The Price of Sagittarius Greek Salad
        /// </summary>
        public override decimal Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 2.00m;
                    case Size.Medium:
                        return 2.50m;
                    case Size.Large:
                        return 3.00m;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The Calories of Sagittarius Greek Salad
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 180;
                    case Size.Medium:
                        return 270;
                    case Size.Large:
                        return 360;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
