using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            Employee employee = new Employee() { FirstName = "John", LastName = "Doe", Id = 001 };
            Employee employee2 = new Employee() { FirstName = "Jane", LastName = "Doe", Id = 002 };

            Console.WriteLine("Do they match? True or false: ");
            Console.WriteLine(employee == employee2);
            Console.ReadLine();
        }
    }
}
