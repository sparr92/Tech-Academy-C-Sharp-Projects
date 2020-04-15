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

            else if (pkgWt <= 50)
            {
                Console.WriteLine("Please enter package width: ");
                decimal pkgWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter package height: ");
                decimal pkgHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter package length: ");
                decimal pkgLength = Convert.ToDecimal(Console.ReadLine());


                decimal totDim = (pkgWidth + pkgHeight + pkgLength);
                decimal quote = (totDim * pkgWt) / 100;
                if (totDim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }

                else if (totDim < 50)
                {
                    Console.WriteLine("Your estimate is $" + quote);
                    Console.ReadLine();
                }
                    
            }


        }
    }
}
