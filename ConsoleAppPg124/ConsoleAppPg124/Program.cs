using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg124
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //employee.SayName();
            //Console.ReadLine();

            IQuittable NewEmployee = new Employee();

            ((Employee)NewEmployee).firstName = "Sample" ;
            ((Employee)NewEmployee).lastName = "Student";

            NewEmployee.Quit();
            Console.ReadLine();
        }
    }
}
