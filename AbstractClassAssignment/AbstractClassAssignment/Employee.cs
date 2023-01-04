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
        public void Quit() // inheriting method from interface
        {
            Console.WriteLine("successful method calling");
        }
    }
}
