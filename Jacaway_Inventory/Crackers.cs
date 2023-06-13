using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_Inventory
{
    internal class Crackers : IShippable
    {
        private int crackercount = 0;
        decimal IShippable.ShipCost
        {
            get { return 0.57m; }
        }
        string IShippable.Product
        {
            get { return "Crackers"; }
        }
        public decimal Cracker
        {
            get { return crackercount++; }
        }
    }
}
