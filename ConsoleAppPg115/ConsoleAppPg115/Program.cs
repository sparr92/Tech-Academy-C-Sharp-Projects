using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg115
{
    class Program
    {
        static void Main(string[] args)
        {
            calc calc = new calc();
            Console.WriteLine("Please enter a number you would like to add 15 to: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number you would like to add to the total (optional): ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calc.Total(number1, number2));
            Console.ReadLine();
        }
    }
}
