using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string petName = "Chowder"; // const variable
            var faveTreat = "Freeze Dried Chicken"; // variable with var keyword

            Person owner = new Person("Buddy"); // instantiates user class and utilizes chained constructor
        }
    }
}
