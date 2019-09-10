using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsMathApp111
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2 = 37;
            int num3 = 15;
            int num4 = 10;
            int num5 = 5;

            Calculator calculator = new Calculator();
            Console.WriteLine("Please enter an integer you would like to perform calculations on: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + calculator.Addition(num1, num2));
            Console.WriteLine(num1 + " * " + num3 + " = " + calculator.Multiplication(num1, num3));
            Console.WriteLine("(" + num1 + " * " + num4 + ") / " + num5 + " = " + calculator.MultDiv(num1, num4, num5));

            Console.ReadLine();
        }
    }
}
