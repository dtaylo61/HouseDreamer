using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;

// This application allows the user to build the house of their dreams at the location of their dreams using the Command Line Console.
namespace HouseDreamer
{
    class HouseDreamer
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the House Dreamer App!\r\n\r\nHere you can build a house exactly how and where you want it!\r\n\r\n");
            Console.WriteLine("        ^");
            Console.WriteLine("       / \\");
            Console.WriteLine("      /   \\");
            Console.WriteLine("     /     \\");
            Console.WriteLine("    /       \\");
            Console.WriteLine("   /         \\");
            Console.WriteLine("  /           \\");
            Console.WriteLine(" /             \\");
            Console.WriteLine("/|-------------|\\");
            Console.WriteLine(" |     ___     |");
            Console.WriteLine(" |    |_|_|    |");
            Console.WriteLine(" |    |_|_|    |");
            Console.WriteLine(" |             |");
            Console.WriteLine(" |             |");
            Console.WriteLine(" |      _      |");
            Console.WriteLine(" |     | |     |");
            Console.WriteLine(" |_____|_|_____|");
            Console.Write("\r\n\r\nLet's get started!\r\n");

            while (true)
            {
                Console.Write("-----------------------------------------------------------------------------------------------------\r\n\r\nEnter the desired location: (i.e., Palm Bay, FL): ");
                string location = Console.ReadLine();

                Console.Write("\r\nEnter the desired landscape: (riverfront, lakefront,\r\nbeachfront, garden, mountains, or city): ");
                string landscape = Console.ReadLine();

                Console.Write("\r\nEnter your desired residential style:\r\n(Art Deco, Bungalow, Cape Cod, Colonial,\r\nContemporary, Craftsman, Dutch Colonial, Federal,\r\nGeorgian, Italianate, Monterey, Ranch, Shingle,\r\nShotgun, Spanish Eclectic): ");
                string style = Console.ReadLine();

                Console.Write("\r\nEnter the desired number of stories: ");
                int numOfStories = Int32.Parse(Console.ReadLine());

                Console.Write("\r\nEnter the desired size in square footage: ");
                int size = Int32.Parse(Console.ReadLine());

                Console.Write("\r\nEnter the desired number of bedrooms: ");
                int numOfBedrooms = Int32.Parse(Console.ReadLine());

                Console.Write("\r\nEnter the desired number of bathrooms: ");
                int numOfBathrooms = Int32.Parse(Console.ReadLine());

                Console.Write("\r\nEnter the desired number of cars you would like to store in the garage: ");
                int garageStorageAmt = Int32.Parse(Console.ReadLine());

                Console.Write("\r\nEnter additional items you would like your house to have (pool, spa, gazebo): ");
                string additionalItems = Console.ReadLine();

                Console.WriteLine("-----------------------------------------------------------------------------------------------\r\nHere's what you chose for your Dream House!!!\r\n----------------------------------------------------------------------------------------------------\r\n");
                Console.WriteLine("Desired Location: " + location);
                Console.WriteLine("Desired Landscape: " + landscape);
                Console.WriteLine("Desired Residential Style: " + style);
                Console.WriteLine("Desired Number of Stories: " + numOfStories);
                Console.WriteLine("Desired Size: " + size + " Square Feet");
                Console.WriteLine("Desired Number of Bedrooms: " + numOfBedrooms);
                Console.WriteLine("Desired Number of Bathrooms: " + numOfBathrooms);
                Console.WriteLine("Desired Garage Size: " + garageStorageAmt + " Car Garage");
                Console.WriteLine("Desired Additional Items: " + additionalItems);

                Console.WriteLine("\r\nWould you like to try it again? If so, type 'y', otherwise type the 'ENTER' key to quit: ");
                string goAgain = Console.ReadLine();

                if (goAgain.ToLower() == "y")
                {
                    continue;
                }
                else 
                {
                    break;
                }
            }
            Console.Write("\r\n\r\nHouse Dreamer...Signing Off");
            Thread.Sleep(5000);     // Provides a 5 second delay before closing the program
        }
    }
}
