using System;

namespace Crownhart_Inventory
{// First or Nickname Lastname
 // IT112 
 // NOTES: Notes the instructor should read
 // BEHAVIORS NOT IMPLEMENTED AND WHY: Are there any parts of the assignment 
 // you did not complete?
    public partial class Program
    {

        static void Main(string[] args)
        {
            IShippable[] shippables = new IShippable[10];

            Shippable ship = new Shippable();
            ship.Add(shippables);
        }
    }
}
