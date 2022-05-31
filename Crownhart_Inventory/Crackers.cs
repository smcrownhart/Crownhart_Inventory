using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_Inventory
{
    class Crackers : IShippable
    {
        private decimal _shipCost;
        private string _product;
        
        public Crackers(decimal ShipCost, string Product)
        {
            _shipCost = ShipCost;
            _product = Product;
        }

        public decimal ShipCost
        {
            get { return _shipCost; }
            set { _shipCost = value; }
        }
        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }

       

        public void Add(IShippable[] items)
        {
            return;
        }
    }
}
