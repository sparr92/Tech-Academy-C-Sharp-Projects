using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 10. Make a guess!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That's right!");
                        isGuessed = true;
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10. That's not it! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("I said 1 to 10! Try again, dum dum.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }

            Console.Read();
        }
    }
}
