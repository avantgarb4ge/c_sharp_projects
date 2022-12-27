using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Travel
    {
        public int gas { get; set; } // constructor? sets class property
        
        // following are 3 different methods, calculates gas in each state
        public int oregon()
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
