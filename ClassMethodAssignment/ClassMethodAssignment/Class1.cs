using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Class1
    {
        public void divisionvoid(int num1)
        {
            int output = num1 / 2;
            Console.WriteLine(output);
        }

        public void returnnum(out int num2) // method with output parameters
        {
            num2 = 818;
        }
        
        // the next two methods are a part of the overloading exercise, by changing the number of parameters
        public int additionMethod(int a, int b) // uses two parameters
        {
            int sum = a + b;
            return sum;
        }

        public int additionMethod(int a, int b, int c) // uses three parameters
        {
            int sum = a + b + c;
            return sum;
        }
    }
}
