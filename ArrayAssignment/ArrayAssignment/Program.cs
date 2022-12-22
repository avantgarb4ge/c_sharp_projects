using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] desserts = {"cookie", "pie", "cake", "brownie", "danish" };
            Console.WriteLine("Choose a random dessert! Pick a number between 0-4.");
            int randomDessert = Convert.ToInt32(Console.ReadLine());
            // running if loop if user choose number outside array index
            if (randomDessert > 4)
            {
                // shaming user for not abiding orders
                Console.WriteLine("You didn't follow instructions. Pick a number between 0-4.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(desserts[randomDessert]);
                Console.ReadLine();
            }

            int[] number = { 2, 1, 10, 6, 8 };
            Console.WriteLine("Now guess who many you will receive. Pick a number between 0-4");
            int randomAmount = Convert.ToInt32(Console.ReadLine());
            if (randomAmount > 4)
            {
                Console.WriteLine("You didn't follow instructions. Please pick a number between 0-4.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(number[randomAmount]);
                Console.ReadLine();
            }

            List<string> flavorList = new List<string>();
            flavorList.Add("chocolate");
            flavorList.Add("strawberry");
            flavorList.Add("blueberry");
            flavorList.Add("mocha");
            flavorList.Add("peanut");
            Console.WriteLine("Choose a random flavor! Pick a number between 0-4.");
            int randomFlavor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(flavorList[randomFlavor]);
            Console.ReadLine();
        }
    }
}
