using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0;

            // Display title line
            Console.WriteLine("C# Calculator");
            Console.WriteLine("-----------------");

            // Ask the user to enter a number
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tm - Multiply by 50");
            Console.WriteLine("\ta - Add 25");
            Console.WriteLine("\td - Divide by 12.5");
            Console.WriteLine("\tc - Check if greater than 50 and display whether true or false");
            Console.WriteLine("\tr - Divide by 7 and display remainder");
            Console.Write("Your selecton? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "m":
                    Console.WriteLine($"Your result: {num1} * {50} = " + (num1 * 50));
                    break;
                case "a":
                    Console.WriteLine($"Your result: {num1} + {25} = " + (num1 + 25));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {12.5} = " + (num1 / 12.5));
                    break;
                case "c":
                    Console.WriteLine($"Your result: {num1} > {50} = " + (num1 > 50));
                    break;
                case "r":
                    Console.WriteLine($"Your result: {num1} % {7} = " + (num1 % 7));
                    break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}
