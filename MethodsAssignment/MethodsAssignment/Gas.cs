using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Gas
    {
        // following are 3 different methods, calculates gas in each state
        public int oregon(int x) // need to pass in parameter aka users input
        {
            int product = x * 4;
            return product;
        }
        public int maryland(int x)
        {
            int product = x * 3;
            return product;
        }
        public int texas(int x)
        {
            int product = x * 2;
            return product;
        }
    }
}
