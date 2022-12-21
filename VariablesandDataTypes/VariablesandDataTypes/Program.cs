using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a comment
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string faveNumber = Console.ReadLine();
            int faveNum = Convert.ToInt32(faveNumber);
            int total = faveNum + 5;
            Console.WriteLine("Your favorite number + 5 is: " + total);
            Console.ReadLine();
        }
    }
}
