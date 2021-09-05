﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    public class GeminiStuffedGrapeLeaves
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        /// 

        /// <summary>
        /// The default Size of Gemini Stuffed Grape Leaves
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Public facing getters and setters
        /// </summary>


        /// <summary>
        /// The Size of Gemini Stuffed Grape Leaves
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The Price of Gemini Stuffed Grape Leaves
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
        /// The Calories of Gemini Stuffed Grape Leaves
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 360;
                    case Size.Medium:
                        return 540;
                    case Size.Large:
                        return 720;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}