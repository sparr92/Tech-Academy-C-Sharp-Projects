using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncomeCompProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display title line
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("-----------------");

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            string hourlyRate = Console.ReadLine();
            int hrRate = Convert.ToInt32(hourlyRate);

            Console.WriteLine("Hours worked per week?");
            string hoursWorked = Console.ReadLine();
            int hrsWorked = Convert.ToInt32(hoursWorked);

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            int hrRate2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hrsWorked2 = Convert.ToInt32(hoursWorked2);

            Console.WriteLine("Weekly salary of Person 1");
            int salPers1 = (hrRate * hrsWorked);
            Console.WriteLine(salPers1);
            
            Console.WriteLine("Weekly salary of Person 2?");
            int salPers2 = (hrRate2 * hrsWorked2);
            Console.WriteLine(salPers2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salPers1 > salPers2);
            Console.ReadLine();
        }
    }
}
