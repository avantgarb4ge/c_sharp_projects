using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // overloading == to compare id properties of two objects
        public static bool operator == (Employee emp1, Employee emp2)
        {
            if (emp1.id == emp2.id) // if both values equal each other (data type and value)
            {
                return true;
            }
            return false;
        }

        // wont compile unless the != isnt overloaded as well
        public static bool operator != (Employee emp1, Employee emp2)
        {
            if (!emp1.id.Equals(emp2.id)) // utilizing built in method, have to note not equal by using !
            {
                return true;
            }
            return false;
        }
    }
}
