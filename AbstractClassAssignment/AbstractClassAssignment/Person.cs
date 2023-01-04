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

        public abstract void sayName(); // declaring abstract method, doesnt need implementation 
    }
}
