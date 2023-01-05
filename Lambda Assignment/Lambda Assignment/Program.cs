using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() // created a list of employees, and their values
            {
                new Employee(){id = 1, firstName = "Leslie", lastName = "Knope" },
                new Employee(){id = 2, firstName = "Tom", lastName = "Haverford" },
                new Employee(){id = 3, firstName = "April", lastName = "Ludgate" },
                new Employee(){id = 4, firstName = "Andy", lastName = "Dwyer" },
                new Employee(){id = 5, firstName = "Donna", lastName = "Meagle" },
                new Employee(){id = 6, firstName = "Chris", lastName = "Traeger" },
                new Employee(){id = 7, firstName = "Ben", lastName = "Wyatt" },
                new Employee(){id = 8, firstName = "Ron", lastName = "Swanson" },
                new Employee(){id = 9, firstName = "Jerry", lastName = "Gergich" },
                new Employee(){id = 10, firstName = "Ron", lastName = "Saperstein" },
            };

            //int nameCount = 0;
            //List<Employee> basicList = new List<Employee>(); // instantiate new list to capture names that match requirement
            //foreach (Employee employee in employees)
            //{
            //    if (employee.firstName == "Ron") // if first name is Ron; referencing property we are checking
            //    {
            //        basicList.Add(employee); // add employee to list
            //        nameCount++; // add 1 to value of nameCount
            //    }
            //}
            //foreach (Employee employee in basicList)
            //{
            //    Console.WriteLine(employee.firstName + " " + employee.lastName);
            //}
            //Console.ReadLine();


            List<Employee> newList = employees.Where(x => x.firstName == "Ron").ToList(); // used a LAMBDA expression to do the same function as for each loop

            List<Employee> newList2 = employees.Where(x => x.id > 5).ToList(); // used a LAMBDA expression to add all employees with an ID greater than 5 to a new list

            // running for each loop to check if list has the correct values
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            Console.ReadLine();

            foreach (Employee employee in newList2)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            Console.ReadLine();
        }
    }
}
