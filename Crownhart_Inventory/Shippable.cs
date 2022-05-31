using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_Inventory
{
    class Shippable : IShippable
    {
        private decimal _shipCost;
        private string _product;

        public Shippable()
        {
        }

        public decimal ShipCost
        {
            get
            {
                return _shipCost;
            }
            set
            {
                _shipCost = value;
            }
        }
        public string Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }
        

        public void Add(IShippable[] items)
        {
            int bikeCount = 0; decimal bikeCost = 0; string bike = "";
            int mowerCount = 0; decimal mowerCost = 0; string mower = "";
            int gloveCount = 0; decimal gloveCost = 0; string glove = "";
            int crackerCount = 0; decimal crackerCost = 0; string cracker ="";
            decimal TotalCost = 0;

            Bicycles b = new Bicycles((decimal)9.50, "Bicycle");
            LawnMower m = new LawnMower((decimal)24.00, "Lawn Mower");
            BaseballGloves g = new BaseballGloves((decimal)3.23, "Baseball Glove");
            Crackers c = new Crackers((decimal)0.57, "Crackers");

            Console.WriteLine("Would you like to select items for shipment? y/n");
            string selection = Console.ReadLine();

            if (selection == "y")
            {
                menuDisplay();
                while (selection == "y")
                {
                    
                    
                    string choice = Console.ReadLine();
                    
                    switch (choice)
                    {
                        case "1":
                            
                            bikeCount = bikeCount + 1;
                            bikeCost = b.ShipCost;
                            bike = b.Product;
                            Console.WriteLine("1 Bicycle has been added. Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                        case "2":
                            mowerCount = mowerCount + 1;
                            mowerCost = m.ShipCost;
                            mower = m.Product;
                            Console.WriteLine("1 Lawn Mower has been added. Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                        case "3":
                            gloveCount = gloveCount + 1;
                            gloveCost = g.ShipCost;
                            glove = g.Product;
                            Console.WriteLine("1 Baseball Glove has been added. Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                        case "4":
                            crackerCount = crackerCount + 1;
                            crackerCost = c.ShipCost;
                            cracker = c.Product;
                            Console.WriteLine("1 Crackers has been added. Press any key to return to the menu");
                            Console.ReadKey();
                            break;
                        case "5":
                            Console.WriteLine("Shipment manifest");
                            if (bikeCount == 1)
                            {
                                Console.WriteLine(bikeCount + " " + bike);
                            }
                            else if (bikeCount > 1)
                            {
                                Console.WriteLine(bikeCount + " " + bike + "s");

                            }

                            if (mowerCount == 1)
                            {
                                Console.WriteLine(mowerCount + " " + mower);
                            }
                            else if(mowerCount > 1)
                            {
                                Console.WriteLine(mowerCount + " " + mower + "s");

                            }

                            if (gloveCount == 1)
                            {
                                Console.WriteLine(gloveCount + " " + glove);
                            }
                            else if (gloveCount > 1)
                            {
                                Console.WriteLine(gloveCount + " " + glove + "s");

                            }

                            if (crackerCount >= 1)
                            {
                                Console.WriteLine(crackerCount + " " + cracker);
                            }
                            menuDisplay();
                            break;
                        case "6":
                            TotalCost = 
                            (bikeCount * bikeCost) + (mowerCount * mowerCost) + (gloveCount * gloveCost) + (crackerCount * crackerCost);
                            Console.WriteLine("Your total for this order is: " + TotalCost.ToString("$0.00"));
                            menuDisplay();
                            break;
                        case "0":
                            Console.WriteLine("Bye!");
                            return;
                        default:
                            menuDisplay();
                            break;
                    }
                    
                }

            }
            if (selection == "n")
            {
                Console.WriteLine("Adios!");
            }
            else { 
            
                Console.WriteLine("Sorry... you're not understood");
            }

            
        }
        void menuDisplay()
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|                  Main Menu                     |");
            Console.WriteLine("|1. Add a Bicycle to the shipment                |");
            Console.WriteLine("|2. Add a Lawn Mower to the Shipment             |");
            Console.WriteLine("|3. Add a Baseball Glove to the shipment         |");
            Console.WriteLine("|4. Add Crackers to the shipment                 |");
            Console.WriteLine("|5. List Shipment Items                          |");
            Console.WriteLine("|6. Compute Shipping Charges                     |");
            Console.WriteLine("|0. Exit                                         |");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");
        }
    }
}
