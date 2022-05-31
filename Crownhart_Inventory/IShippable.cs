using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_Inventory
{
    internal interface IShippable
    {
        decimal ShipCost { get; set; }
        string Product { get; set; }

        void Add(IShippable[] items);
        
    }
}
