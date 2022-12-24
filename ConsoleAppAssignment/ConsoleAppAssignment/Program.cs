using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One
            Console.WriteLine("Here is a list of flavors on the menu.");
            string[] flavors = { "chocolate", "vanilla", "coconut", "strawberry", "blueberry" };
            foreach (string f in flavors) //this is to display the list to the user
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("We need a dessert type. Add your favorite generic dessert name.");
            string addDessert = Console.ReadLine(); //saves users input
            for (int f = 0; f < flavors.Length; f++) //iterates through list
            {
                flavors[f] = flavors[f] + " " + addDessert; //adds users input to end of each string value
            }
            Console.WriteLine("Great! So now we have:");
            for (int f = 0; f < flavors.Length; f++) //iterates through array
            {
                Console.WriteLine(flavors[f]); //display element
                Console.ReadLine();
            }

            // Part Two/Three
            //To prevent an infinite loop, I set i < 10 so the program would stop after i = 9
            //This also fulfills part of part 3, utilizing the < comparison
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            for (int i = 0; i <= 10; i++) // compares using <=
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            // Part Four
            List<string> meals = new List<string>() { "breakfast", "lunch", "dinner", "dessert", "appetizer" };
            Console.WriteLine("What meal time are you looking for?");
            string pickMeal = Console.ReadLine();
            bool matchExists = false;
            for (int m = 0; m < meals.Count; m++)
            {
                if (pickMeal == meals[m]) // if the users input is the same as an item in the array, run loop
                {
                    matchExists = true; // changes bool to true in order to print the following
                    Console.WriteLine(m); // prints string in array
                    break; //stops method once it finds its match
                }
            }
            if (matchExists == false) //bool is always going to equal false so this runs if it doesnt find match
            { //cant put "else" in previous loop, otherwise it produces this statement for every string that doesnt match
                Console.WriteLine("This is not in the list.");
            }
            Console.ReadLine();

            // Part Five //similar set up as previous section
            List<string> bodyParts = new List<string>() { "arm", "leg", "head", "arm", "torso", "foot" };
            Console.WriteLine("Write a body part.");
            string chosenLimb = Console.ReadLine();
            bool matching = false;
            for (int b = 0; b < bodyParts.Count; b++)
            {
                if (chosenLimb == bodyParts[b])
                {
                    matching = true;
                    Console.WriteLine(b); //removed break to find all matches
                }
            }
            if (matching == false)
            {
                Console.WriteLine("This is not in the list.");
            }
            Console.ReadLine();

            // Part Six
            List<string> animals = new List<string>() { "dog", "cat", "snake", "rat", "fish", "cat" };
            List<string> duplicates = new List<string>() { }; //create new empty list to compare
            foreach (string a in animals) // run through each string in array 
            {
                if (duplicates.Contains(a)) // if new list contains this element in original list
                {
                    Console.WriteLine(a + ": This element is a duplicate string.");
                    duplicates.Add(a);
                }
                else
                {
                    Console.WriteLine(a + ": This element is a single string.");
                    duplicates.Add(a); // adds element in the new list for comparison later
                }
            }
            Console.ReadLine();
        }
    }
}
