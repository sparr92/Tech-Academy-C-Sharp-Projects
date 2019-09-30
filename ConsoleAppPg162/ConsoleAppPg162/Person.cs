using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg162
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdNumber { get; set; }

        public Person(string fName, string lName)
            : this(fName, lName, 0)
        {
        }
        public Person(string fName, string lName, int id)
        {
            FirstName = fName;
            LastName = lName;
            IdNumber = id;
        }

    }
}
