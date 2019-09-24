using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppPg154
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask a user for a number.
            // 2.Log that number to a text file.
            // 3.Print the text file back to the user.

            Console.WriteLine("Please enter a number: ");
            string writeNumber = Console.ReadLine();
            File.WriteAllText("C:\\Sample\\Logs\\log.txt", writeNumber);
            string readText = File.ReadAllText("C:\\Sample\\Logs\\log.txt");
            Console.WriteLine("You entered: " + readText);
            Console.ReadLine();
        }
    }
}
