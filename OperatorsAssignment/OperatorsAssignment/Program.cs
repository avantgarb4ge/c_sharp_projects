using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating object and its properties
            Employee emp1 = new Employee();
            emp1.id = 01;
            emp1.firstName = "bob";
            emp1.lastName = "the builder";

            Employee emp2 = new Employee();
            emp2.id = 01;
            emp2.firstName = "thomas";
            emp2.lastName = "the train";

            // comparing values, then adjusting output to console depending on result
            if (emp1 == emp2)
            {
                Console.WriteLine("These employees have the same id number.");
            }
            else
            {
                Console.WriteLine("These employees have different id numbers.");
            }
            Console.ReadLine();
        }
    }
}
