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
            int userNum1, userNum2;
            int result;
            Console.WriteLine("Please enter a number you would like to add to 15: ");
            if (!int.TryParse(Console.ReadLine(), out userNum1))
            {
                throw new ArgumentException("No valid number entered");
            }

            Console.WriteLine("Please enter second number you would like to add to the total (optional): ");
            if (int.TryParse(Console.ReadLine(), out userNum2))
            {
                result = calc.Total(userNum1, userNum2);
            }
            else
            {
                result = calc.Total(userNum1);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
