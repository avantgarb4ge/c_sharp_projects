using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 thing1 = new Class1(); // instantiates new class object
            Console.WriteLine("Please input a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            thing1.divisionvoid(x); // calling void method with user input argument
            thing1.divisionvoid(x); // calling void method with user input argument
            Console.ReadLine();

            Class1 thing2 = new Class1(); // instantiates new class object
            int y = 0; // define local variable
            thing2.returnnum(out y); // calls method w output parameters, will replace method outcome into local variable
            Console.WriteLine("here is the result of using output parameters: " + y);
            Console.ReadLine();

            Class1 thing3 = new Class1(); // instantiates new class object
            int sum1 = thing3.additionMethod(2, 5);
            Console.WriteLine("2 plus 5 equals " + sum1);
            Console.ReadLine();
            int sum2 = thing3.additionMethod(13, 9, 74); // input extra argument for same method
            Console.WriteLine("13 plus 9 plus 74 equals " + sum2);
            Console.ReadLine();
        }
    }
}
