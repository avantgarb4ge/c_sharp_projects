using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year was Paris Hilton born?");
            int guessYear = Convert.ToInt32(Console.ReadLine());
            bool year = guessYear == 1981;

            do
            {
                switch (guessYear)
                {
                    case 1982:
                        Console.WriteLine("Just one year away, guess again!");
                        guessYear = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1983:
                        Console.WriteLine("Right decade, wrong year. Guess again!");
                        guessYear = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1980:
                        Console.WriteLine("Just one year away, guess again!");
                        guessYear = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1981:
                        Console.WriteLine("You got it! No trust fund for you though.");
                        year = true;
                        break;
                    default:
                        Console.WriteLine("Wrong. Guess again. Please. I beg of you.");
                        guessYear = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!year);

            Console.Read();
        }
    }
}
