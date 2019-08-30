using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApprovalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Calculator");
            Console.WriteLine("-----------------------------------");

            int age;
            bool hasDui;
            string duiStatus;
            int numTix;

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            duiStatus = Console.ReadLine();
            hasDui = duiStatus.Equals("yes");

            Console.WriteLine("How many speeding tickets do you have?");
            numTix = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool isQualified = (age > 15 && hasDui == false && numTix <= 3);

            Console.WriteLine(isQualified);
            Console.ReadLine();

        }
    }
}
