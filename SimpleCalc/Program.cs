using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the first Integer
            Console.WriteLine("First Integer: ");
            // Initialize the first variable
            String firstInt;
            // Accept the user input for the first Integer
            firstInt = Console.ReadLine();
            // Parse the user input into an Integer for calculation
            int parseInt1 = int.Parse(firstInt);

            // Prompt the user for the second Integer
            Console.WriteLine("Second Integer: ");
            // Initialize the second variable
            String secondInt;
            // Accept the user input for the second Integer for calculation
            secondInt = Console.ReadLine();
            // Parse the user input into an Integer for calculation
            int parseInt2 = int.Parse(secondInt);

            // Do the calculation
            int result = parseInt1 + parseInt2;
            // Show result (variable result is implicitly converted to string for output
            Console.WriteLine("The result is: " + result);
            // Keep console open until enter key is used
            Console.ReadLine();
        }
    }
}
