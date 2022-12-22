using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package? Please use lbs.");
            int weight = Convert.ToInt32(Console.ReadLine());
            // if statement to split program path if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("The package is too heavy to ship through Package Express. Try UPS.");
                Console.ReadLine();
            }

            // if weight is 50 or less
            else
            {
                Console.WriteLine("What is the width of the package?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of the package?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of the package?");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimension = length + width + height;
                // another if statement if dimensions are too large
                if (dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int costCalculation = (length * width * height * weight)/100;
                    Console.WriteLine("The total cost for shipment is: " + costCalculation);
                    Console.ReadLine();
                }
            }
        }
    }
}
