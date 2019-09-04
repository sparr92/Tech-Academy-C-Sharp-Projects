using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my name?");
            string name = Convert.ToString(Console.ReadLine());
            bool isGuessed = name == "Sarah";

            do
            {
                switch (name)
                {
                    case "Emily":
                        Console.WriteLine("Nope, sorry! Try again.");
                        name = Convert.ToString(Console.ReadLine());
                        break;

                    case "Sophie":
                        Console.WriteLine("Nope, sorry! Try again.");
                        name = Convert.ToString(Console.ReadLine());
                        break;

                    case "Katie":
                        Console.WriteLine("Nope, sorry! Try again.");
                        name = Convert.ToString(Console.ReadLine());
                        break;

                    case "Sarah":
                        Console.WriteLine("You got it! Good job, friend-o.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope, sorry! Try again.");
                        name = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
