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
            Console.WriteLine("First Integer: ");
            String firstInt;
            firstInt = Console.ReadLine();
            int parseInt1 = int.Parse(firstInt);

            Console.WriteLine("Second Integer: ");
            String secondInt;
            secondInt = Console.ReadLine();
            int parseInt2 = int.Parse(secondInt);

            int result = parseInt1 + parseInt2;
            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
        }
    }
}
