using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Person
    {
        //Properties of user
        public string ownerName { get; set; }
        public string petName { get; set; }

        public Person(string ownerName) : this(ownerName, "Garfield") // constructor with default pet name chained
        {

        }

        public Person(string ownerName, string petName)  //main constructor
        {
            this.ownerName = ownerName;
            this.petName = petName;
        }
    }
}
