using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable // inherits from Person class and interface
    {
        public override void sayName() // inherited method, but overwritten
        {
            Console.WriteLine("This the full name: " + firstName + " " + lastName);
        }
        public void Quit(Person person) // inheriting method from interface
        {
            System.Environment.Exit(0);
        }
    }
}
