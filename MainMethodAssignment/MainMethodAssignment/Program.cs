using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates new object
            Methods unit = new Methods();
            // calls first method
            Console.WriteLine("The first method total is: " + unit.mathOperation(5));
            Console.ReadLine();

            Methods unit1 = new Methods();
            // calls second method
            Console.WriteLine("The second method total is: " + unit1.mathOperation(5.8));
            Console.ReadLine();

            Methods unit2 = new Methods();
            // calls third method
            Console.WriteLine("The third method total is: " + unit2.mathOperation("11"));
            Console.ReadLine();
        }
    }
}
