using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Methods
    {
        // first method
        public int mathOperation(int num)
        {
            int total = num + 45;
            return total;
        }
        
        // second method takes in decimal
        public int mathOperation(double num)
        {
            int num1 = Convert.ToInt32(num);
            int total = (int)(num1 - 2.2); // explicit cast? not sure why this removes the red squiggly
            return total;
        }

        // third method takes in string
        public int mathOperation(string num)
        {
            int num1 = Convert.ToInt32(num);
            int total = num1 + 3;
            return total;
        }
    }
}
