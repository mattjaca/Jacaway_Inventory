using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_Inventory
{
    internal class Bicycle : IShippable
    {
        decimal IShippable.ShipCost
        {
            get { return 9.50m; }
        }
        string IShippable.Product
        {
            get { return "Bicycle";  }
        }
    }
}
