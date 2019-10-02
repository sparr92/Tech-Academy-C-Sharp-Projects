using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg165
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
            : base() { }
        public InvalidAgeException(string message)
            : base(message) { }
    }
}
