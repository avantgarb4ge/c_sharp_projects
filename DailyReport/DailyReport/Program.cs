using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing first few statements, then question
            Console.WriteLine("The Tech Academy \nDaily Report");
            Console.WriteLine("What is your name?");
            // save response as string "name"
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            // converts string input into int data type
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? True/False");
            string helpAnswer = Console.ReadLine();
            // converts string input into boolean data type
            bool helpResponse = Convert.ToBoolean(helpAnswer);
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            // converts string input into byte data type
            byte hours = Convert.ToByte(studyHours);
            Console.WriteLine("Thank you for your answers.\nAn Instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine();
        }
    }
}
