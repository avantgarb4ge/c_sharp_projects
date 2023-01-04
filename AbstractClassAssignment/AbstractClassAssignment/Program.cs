using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee(); // instantiate new object
            name.firstName = ("sample"); // declaring values for properties
            name.lastName = ("student");

            name.sayName(); // calling method
            Console.ReadLine();

            IQuittable quitter = new Employee(); // instantiate new object since Employee class inherits from IQuittable interface
            Console.ReadLine();
        }
    }
}
