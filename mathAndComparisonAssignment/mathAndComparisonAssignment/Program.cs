using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your annual income?");
            string p1salary = Console.ReadLine();
            int p1income = Convert.ToInt32(p1salary);
            Console.WriteLine("How many hours do you work a week?");
            string p1hours = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your annual income?");
            string p2salary = Console.ReadLine();
            int p2income = Convert.ToInt32(p2salary);
            Console.WriteLine("How many hours do you work a week?");
            string p2hours = Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 1: " + p1income);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2: " + p2income);
            Console.ReadLine();
            bool incomeCompare = p1income > p2income;
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(incomeCompare);
            Console.ReadLine();
        }
    }
}
