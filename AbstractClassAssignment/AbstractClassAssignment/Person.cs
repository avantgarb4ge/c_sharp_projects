using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person // declaration of abstract class
    {
        // establishes properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void sayName() // method, but can't be called unless inherited, therefore virtual must be inputted for access
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
