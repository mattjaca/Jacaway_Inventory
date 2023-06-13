using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_Inventory
{
    internal class Shipper
    {
        private List<IShippable> _items = new List<IShippable>(10);
        private int Bikecount;
        private int Lawncount;
        private int Glovecount;
        private int Crackercount;
        private int itemcount;
        public void Add(IShippable item)
        {
            if (_items.Count < 10)
            {
                _items.Add(item);
                itemcount++;
            }
        }
        public decimal Full
        {
            get { return itemcount; }
        }
        public string AddedItem()
        {
            string result = string.Empty;
            foreach (IShippable item in _items)
            {
                result = "Added " + item.Product + " to order.";
            }
            return result;
        }
        public decimal ComputeShippingCharges()
        {
            decimal amount = 0;
            foreach (IShippable item in _items)
            {
                amount += item.ShipCost;
            }
            return amount;
        }

        public string ListItems()
        {
            string bike = " Bicycles\n";
            string Mower = " Lawn Mowers\n";
            string Glove = " Baseball Gloves\n";

            foreach (IShippable item in _items)
            {
                if (item.GetType() == typeof(Bicycle))
                {
                    Bikecount++;
                }
                if (item.GetType() == typeof(LawnMower))
                {
                    Lawncount++;
                }
                if (item.GetType() == typeof(Crackers))
                {
                    Crackercount++;
                }
                if (item.GetType() == typeof(BaseballGlove))
                {
                    Glovecount++;
                }
            }
            if(Bikecount == 1)
            {
                bike = " Bicycle \n";
            }
            if (Lawncount == 1)
            {
                Mower = " Lawn Mower \n";
            }
            if (Glovecount == 1)
            {
                Glove = " Baseball Glove \n";
            }

            return "Shipment List: \n" + Bikecount + bike + Lawncount + Mower + Glovecount + Glove + Crackercount + " Crackers";
        }  
    }
}