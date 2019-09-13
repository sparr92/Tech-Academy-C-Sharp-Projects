using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg140
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Make list of at least 10 employees, at least two w/ first name "Joe" 
            Employee emp1 = new Employee()
            {
                FirstName = "Jane",
                LastName = "Smith",
                IdNumber = 0001
            };
            Employee emp2 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Smith",
                IdNumber = 0002
            };
            Employee emp3 = new Employee()
            {
                FirstName = "John",
                LastName = "Doe",
                IdNumber = 0003
            };
            Employee emp4 = new Employee()
            {
                FirstName = "Eli",
                LastName = "Poe",
                IdNumber = 0004
            };
            Employee emp5 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Gill",
                IdNumber = 0005
            };
            Employee emp6 = new Employee()
            {
                FirstName = "Bill",
                LastName = "Englund",
                IdNumber = 0006
            };
            Employee emp7 = new Employee()
            {
                FirstName = "Alan",
                LastName = "Jones",
                IdNumber = 0007
            };
            Employee emp8 = new Employee()
            {
                FirstName = "Jane",
                LastName = "Jones",
                IdNumber = 0008
            };
            Employee emp9 = new Employee()
            {
                FirstName = "Rachel",
                LastName = "Jackson",
                IdNumber = 0009
            };
            Employee emp10 = new Employee()
            {
                FirstName = "Janet",
                LastName = "Johnson",
                IdNumber = 00010
            };

            List<Employee> Employees = new List<Employee>();
            Employees.Add(emp1);
            Employees.Add(emp2);
            Employees.Add(emp3);
            Employees.Add(emp4);
            Employees.Add(emp5);
            Employees.Add(emp6);
            Employees.Add(emp7);
            Employees.Add(emp8);
            Employees.Add(emp9);
            Employees.Add(emp10);

            // 2. Make new list of all employees w/ first name "Joe" using foreach loop
            List<string> duplFNames = new List<string>();

            foreach (Employee employee in Employees)
                if (employee.FirstName == "Joe")
                {
                    duplFNames.Add(employee.FirstName);
                }
            for (int i = 0; i < duplFNames.Count; i++)
            {
                Console.WriteLine(duplFNames[i]);
            }

            // 3. Lambda Expression
            var result = Employees.Select(q => q).Where(q => q.FirstName == "Joe");
            foreach (Employee employee in result)
                Console.WriteLine(employee.FirstName);

            // 4. Using lambda expression, make list of all employees w/ Id number greater than 5

            var result2 = Employees.Select(y => y).Where(y => y.IdNumber > 0005);
            foreach (Employee employee in result2)
                Console.WriteLine(employee.IdNumber);

            Console.ReadLine();
        }
    }
}


    