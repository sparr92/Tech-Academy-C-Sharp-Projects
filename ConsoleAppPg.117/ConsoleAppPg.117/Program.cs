using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg._117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.fName + " " + Student.lName);
            Console.WriteLine(Student.schoolName);
            Calc calc = new Calc();
            Console.WriteLine("Please enter a number you would like to divide by two: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            calc.Divide(number1);

            Console.WriteLine(calc.Add(17, 83));
            Console.WriteLine(calc.Add(2.3, 5.92));
            Console.WriteLine(calc.Add(5, 6, 7));

            int a, b;
            Square(out a, out b);
            Console.WriteLine("The value squared is: {0}", a);
            Console.WriteLine("The value squared is: {0}", b);

            Console.ReadLine();
        }
        public static void Square(out int a, out int b)
        {
            a = 20;
            b = 15;
            a += a;
            b += b;
        }
    }
}
