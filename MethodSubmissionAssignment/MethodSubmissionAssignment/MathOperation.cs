using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class MathOperation
    {
        // passes in two paramerts, sets num2 to a default if user opts out of second input
        public int operation(int num1, int num2 = 10)
        {
            int total = num1 + num2;
            return total;
        }
    }
}
