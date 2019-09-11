using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg._117
{
    public class Calc
    {
        public void Divide(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(num1 + " / " + 2 + " = " + result);
            Console.WriteLine("Press enter to do some more calculations: ");
            Console.ReadLine();
        }
        public int Add(int i, int j)
        {
            return i + j;
        }
        public int Add(int i, int j, int k)
        {
            return i + j + k;
        }
        public int Add(double i, double j)
        {
            return Convert.ToInt32(i + j);
        }
    }
}
