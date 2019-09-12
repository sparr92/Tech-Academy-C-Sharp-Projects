using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg134
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string currentDay = Console.ReadLine();
                WeekDays day;
                if (Enum.TryParse<WeekDays>(currentDay, out day))
                {
                    Console.WriteLine("Today is " + currentDay);
                    Console.ReadLine();
                }
                else
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        public enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
    }
}
