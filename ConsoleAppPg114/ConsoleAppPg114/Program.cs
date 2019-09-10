using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg114
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Math(num1: 12));
            Console.WriteLine(calculator.Math(num2: 5.67));
            Console.WriteLine(calculator.Math(num3: "40"));
            Console.ReadLine();
        }
    }
}
