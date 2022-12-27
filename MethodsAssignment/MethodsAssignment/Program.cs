using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel trip1 = new Travel();
            Console.WriteLine("How many gallons of gas do you need?");
            trip1.gas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(trip1.gas + " gallons of gas in Oregon would cost $" + trip1.oregon());
            Console.WriteLine(trip1.gas + " gallons of gas in Maryland would cost $" + trip1.maryland());
            Console.WriteLine(trip1.gas + " gallons of gas in Texas would cost $" + trip1.texas());

            Console.ReadLine();

        }
    }
}
