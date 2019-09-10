using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg114
{
    public class Calculator
    {
        public int Math(int num1)
        {
            return num1 + 17;
        }
        public int Math(double num2)
        {
            return Convert.ToInt32(num2 * 3);
        }
        public int Math(string num3)
        {
            return Convert.ToInt32(num3)/4;
        }

    }
}
