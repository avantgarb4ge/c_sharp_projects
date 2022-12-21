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
            Console.WriteLine("What is your hourly rate?");
            int p1rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            int p1hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int p2rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            int p2hours = Convert.ToInt32(Console.ReadLine());

            int p1income = p1rate * p1hours * 52;
            int p2income = p2rate * p2hours * 52;
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
