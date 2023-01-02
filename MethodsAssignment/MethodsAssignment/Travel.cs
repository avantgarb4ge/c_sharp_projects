using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Travel
    {
        // following are 3 different methods, calculates gas in each state
        public int oregon(int gas) // need to pass in parameter aka users input
        {
            return (int)(gas * 4.1);
        }
        public int maryland(int gas)
        {
            return (int)(gas * 3.75);
        }
        public int texas(int gas)
        {
            return (int)(gas * 2.34);
        }
    }
}
