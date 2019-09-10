using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsMathApp111
{
    public class Calculator
    {
        // Add integer to 37
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        // Multiply two numbers
        public int Multiplication(int num1, int num3)
        {
            return num1 * num3;
        }
        // Subtracts smaller number from bigger number
        public int MultDiv(int num1, int num4, int num5)
        {
            return (num1 * num4) / num5;
        }

    }
}
