using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);// prints the current date and time 
            Console.WriteLine("Please enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            TimeSpan userHours = new TimeSpan(0, x, 0, 0); //creates a timespan variable and passes int x as a parameter
            DateTime currentTime = DateTime.Now; // creates datetime varaiable w the current date and time
            DateTime futureTime = currentTime.Add(userHours); // adds the timespan variable to the datetime currenttime variable and assigns it a to futuretime variable
            string fTime = futureTime.ToString("hh:mm tt"); // converts datetime variable to a string that holds specific parameters of the datetime variable
            Console.WriteLine("In " + x + " hours it will be " + fTime); // displays time it will be in the amount of hours that the user entered
            Console.ReadLine();
        }
    }
}
