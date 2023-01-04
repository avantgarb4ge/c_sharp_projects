using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable // inherits from Person class
    {
        public override void sayName() // inherited method, but overwritten
        {
            Console.WriteLine("This the full name: ");
            base.sayName(); // automatic, but i suppose this still executes the method procedure in Person class
        }
        public void Quit(Person person)
        {
            System.Environment.Exit(0);
        }
    }
}
