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
            // instantiates new object
            Gas trip1 = new Gas();
            Console.WriteLine("How many gallons of gas do you need?");
            // assigns user input to class property
            int x = Convert.ToInt32(Console.ReadLine());

            // calls each of the methods, must pass in argument
            Console.WriteLine(x + " gallons of gas in Oregon would cost $" + trip1.oregon(x));
            Console.WriteLine(x + " gallons of gas in Maryland would cost $" + trip1.maryland(x));
            Console.WriteLine(x + " gallons of gas in Texas would cost $" + trip1.texas(x));

            Console.ReadLine();
        }
    }
}
