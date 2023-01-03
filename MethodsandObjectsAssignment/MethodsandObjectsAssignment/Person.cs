using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    public class Person // have to set to public in order to access between files
    {
        public string firstName { get; set; } // get and set value to established property
        public string lastName { get; set; }

        public void SayName() // method
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
