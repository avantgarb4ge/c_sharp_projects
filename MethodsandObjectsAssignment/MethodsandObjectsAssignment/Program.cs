using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee title = new Employee(); // instantiate new employee object
            title.firstName = ("sample"); // setting firstName value
            title.lastName = ("student"); // setting lastName value

            title.SayName(); // calling method in Person class
            Console.ReadLine();
        }
    }
}
