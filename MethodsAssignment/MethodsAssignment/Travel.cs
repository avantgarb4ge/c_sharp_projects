using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Travel
    {
        public int gas { get; set; } // constructor
        
        public int oregon() // method 1: calculate gas total from user's input
        {
            return (int)(gas * 4.1);
        }
        public int maryland()
        {
            return (int)(gas * 3.75);
        }
        public int texas()
        {
            return (int)(gas * 2.34);
        }
    }
}
