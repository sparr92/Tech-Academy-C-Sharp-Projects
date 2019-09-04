using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemoPg97
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Marge";
            string lastName = "Simpson";

            StringBuilder sb = new StringBuilder();

            sb.Append("Chapter One: Starts and Beginnings \n \t \"Swim, swim, swim,\" thought the whale, flapping his flappers.");

            lastName = lastName.ToUpper();

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(" ");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
