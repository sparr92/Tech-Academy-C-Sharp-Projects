using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg124
{
    public abstract class Person
    {
        public List<string> Persons { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
    }
}

