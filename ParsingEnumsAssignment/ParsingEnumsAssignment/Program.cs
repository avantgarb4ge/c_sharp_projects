using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    public enum WeekDay // create weekday enum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try // added try 
            {
                Console.WriteLine("Please enter the current day of the week"); // ask user for input
                WeekDay dayOfTheWeek = (WeekDay)Enum.Parse(typeof(WeekDay), Console.ReadLine(), true); // convert input to enum and used bool parameter to ignore case sensitivity
                Console.WriteLine("You entered: " + dayOfTheWeek);         
            }
            catch (Exception) // exception handle
            {
                Console.WriteLine("Please enter an actual day of the week."); // message to user if exception occurs
            }
            finally // will always run whether an exception is raised or not
            {
                Console.ReadLine();
            }
        }
    }
}
