using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg113
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("Please enter a number you would like to add 14 to: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number you would like to display: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            calc.Addition(number1, number2);
            calc.Addition(num1: 5, num2: 8);
            Console.ReadLine();
        }
    }
}
