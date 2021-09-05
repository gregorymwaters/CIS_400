using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Entrees
{
    public class PicesFishDish
    {
        public decimal Price { get { return 5.99m; } }
        public uint Calories { get { return 726; } }
        public IEnumerable<string> SpecialInstructions { get { return new List<string>(); } }

    }
}
