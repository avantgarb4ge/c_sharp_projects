using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 thing = new Class1(); // instantiates object
            thing.vMethod(10, 20); //calling void method
            thing.vMethod(p2: 35, p1: 5); // calling void method with named parameters
            Console.ReadLine();
        }
    }
}
