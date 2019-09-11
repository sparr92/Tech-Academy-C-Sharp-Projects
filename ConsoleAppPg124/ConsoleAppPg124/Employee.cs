using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg124
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I, " + firstName + " " + lastName + ", quit! You can take this job and shove it!");
        }
    }
}
