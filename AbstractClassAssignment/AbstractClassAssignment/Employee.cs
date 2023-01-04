using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person // inherits from Person class
    {
        public override void sayName() // inherited method, but overwritten
        {
            Console.WriteLine("This the full name: ");
            base.sayName(); // automatic, but i suppose this still executes the method procedure in Person class
        }
    }
}
