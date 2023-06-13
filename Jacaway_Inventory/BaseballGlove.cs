using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_Inventory
{
    internal class BaseballGlove : IShippable
    {
        decimal IShippable.ShipCost
        {
            get { return 3.23m; }
        }
        string IShippable.Product
        {
            get { return "Baseball Glove"; }
        }
    }
}
