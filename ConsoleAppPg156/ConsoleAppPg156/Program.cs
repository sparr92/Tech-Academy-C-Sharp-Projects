using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg156
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Print the current date and time to the console.
            // 2. Ask the user for a number.
            // 3. Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            Console.WriteLine("Please enter a number of hours you would like to add to the current time: ");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(x);
            Console.WriteLine("The current time and date is " + now + ". In " + x + " hours, it will be " + later + ".");
            Console.ReadLine();
        }
    }
}
