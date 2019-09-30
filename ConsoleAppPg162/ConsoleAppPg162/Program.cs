using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg162
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a const variable
            // 2.Create a variable using the keyword "var".
            // 3.Chain two constructors together.

            var Students = new List<Person>()
            {
                new Person("Sarah", "Parr"),
                new Person("John", "Parr", 4628)
            };

            const string contactMsg = "Please contact the admin for a new ID number.";
            foreach (var student in Students)
            {
                Console.WriteLine($"Welcome, {student.FirstName} {student.LastName}! Your ID number is {student.IdNumber}.");
                if (student.IdNumber == 0)
                    Console.WriteLine(contactMsg);
            }
            
            Console.ReadLine();
        }
    }
}
