using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation part1 = new MathOperation();
            Console.WriteLine("Please enter two numbers, one at a time. Note, the second number is optional.");
            // registers first user input
            int num1 = Convert.ToInt32(Console.ReadLine());
            // registers second user input, but as string
            string num2 = Console.ReadLine();
            // if num2 is blank, the use default number and only pass in num1 argument
            if (num2 == "")
            {
                Console.WriteLine(num1 + " plus 10 (default) equals " + part1.operation(num1));
            }
            // if num2 is inputted, pass in both arguments
            else
            {
                int newnum2 = Convert.ToInt32(num2);
                Console.WriteLine(num1 + " plus " + newnum2 + " equals " + part1.operation(num1, newnum2));
            }
            Console.ReadLine();
        }
    }
}
