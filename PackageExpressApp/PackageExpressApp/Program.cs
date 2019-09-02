using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Please enter package weight in lbs.:");
            int pkgWt = Convert.ToInt32(Console.ReadLine());

            if (pkgWt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            else
            Console.WriteLine("Please enter package width: ");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height: ");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length: ");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            if (pkgWidth + pkgHeight + pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            else


                Console.WriteLine("Your estimate is $" + (pkgWidth + pkgHeight + pkgLength));
                Console.ReadLine();
        }
    }
}
