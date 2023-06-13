using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_Inventory
{
    internal class LawnMower : IShippable
    {
        decimal IShippable.ShipCost
        {
            get { return 24m; }
        }
        string IShippable.Product
        {
            get { return "Lawn Mower"; }
        }
    }
}
