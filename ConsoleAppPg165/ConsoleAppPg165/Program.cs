using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                var year = DateTime.Now.Year;
                var birthYear = year - age;
                if (age == 0)
                {
                    throw new InvalidAgeException("Please don't enter 0: ");
                }
                else if (age < 0)
                {
                    throw new InvalidAgeException("Please enter a positive whole integer: ");
                }
                else
                {
                    Console.WriteLine("You were born in " + birthYear);
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please enter a valid age: ");
            }
            Console.ReadLine();
        }
    }
}
