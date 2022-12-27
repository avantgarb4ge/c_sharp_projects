using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numList = new List<int> { 45, 3, 29, 88, 7 };
                Console.WriteLine("Pick a divisor.");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int n in numList)
                {
                    int quotient = n / divisor;
                    Console.WriteLine(n + " divided by " + divisor + " equals " + quotient);
                }
                Console.ReadLine();
            }
            catch(FormatException ex) // run if user inputs string
            {
                Console.WriteLine("Please type a whole number."); 
            }
            catch (DivideByZeroException ex) // run if user inputs 0
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) // if exception is neither of above
            {
                Console.WriteLine(ex.Message);
            }
            finally // displays after try catch block is used
            {
                Console.WriteLine("The program has emerged from the try/catch block.");
                Console.ReadLine();
            }
        }
    }
}
