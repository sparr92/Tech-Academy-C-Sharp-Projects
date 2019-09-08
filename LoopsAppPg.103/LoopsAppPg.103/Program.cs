using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. creates string array of names, adds user-inputted greeting to each name,
        // and displays greeting with each name 
        string[] names = { "Momo", "Sarah", "Nathan" };
        Console.WriteLine("Please enter a greeting:");
        string greeting = Convert.ToString(Console.ReadLine());

        foreach (string name in names)
        {
            Console.WriteLine(greeting + ", " + name + "!");
        }

        // 2. creates infinite loop

        int num = -1;
        while (num < 0 || num > 10)
        {
            // 3. fixes infinite loop

            Console.Write("Enter a number between 0 and 10:  ");
            string input = Console.ReadLine();
            num = Convert.ToInt32(input);
        }

        // 4. creates loop where comparison used to determine whether
        // to continue iterating the loop is a “<” operator 
        List<double> tshLevels = new List<double>();
        tshLevels.Add(0.02);
        tshLevels.Add(0.001);
        tshLevels.Add(1.4);
        tshLevels.Add(2.8);
        tshLevels.Add(5.3);
        tshLevels.Add(0.5);

        foreach (double level in tshLevels)
        {
            if (level < 0.5)
            {
                Console.WriteLine("TSH is low at " + level);
            }
        }

        // 5. creates loop where comparison used to determine whether
        // to continue iterating the loop is a “<=” operator 

        List<double> t4Levels = new List<double>();
        t4Levels.Add(0.5);
        t4Levels.Add(1.4);
        t4Levels.Add(1.7);
        t4Levels.Add(.9);
        t4Levels.Add(.7);
        t4Levels.Add(0.4);
        t4Levels.Add(0.6);

        foreach (double level in t4Levels)
        {
            if (level <= 0.6)
            {
                Console.WriteLine("T4 is low at " + level);
            }
        }

        // 6. Create list of strings where each item is unique. Ask user to enter text to search for in the list.
        // Create loop that iterates through the list, then displays index of the array

        List<string> depts = new List<string> { "endocrinology", "neurology", "nephrology", "gastroenterology" };

        Console.WriteLine("Please search the directory for a hospital department: ");
        string userDept = Convert.ToString(Console.ReadLine());
        bool isMatched = false;

        for (int i = 0; i < depts.Count; i++)
        {
            if (depts[i] == userDept)
            {
                Console.WriteLine(i);
                isMatched = true;
                // 8. stop loop from executing once match has been found
                break;
            }
            // 7. Add code to loop to tell user if text they entered isn't in list
        }
        if (isMatched == false)
        {
            Console.WriteLine("You searched for " + userDept + ". That department is either in another building or does not exist.");
        }

    
        //9. create list of strings w/ at least two identical strings. Ask user to enter text to search for in the list.
        // Create a loop that iterates through the list, then displays the indices that contain matching text on the screen.

        List<string> doctors = new List<string>() { "Dr. Smith", "Dr. Stacey", "Dr. Holmes", "Dr. Diamond", "Dr. Smith" };

        Console.WriteLine("Please enter doctor's name (e.g. Dr. Adams): ");
        string userDr = Convert.ToString(Console.ReadLine());
        bool isMatched2 = false;

        for (int k = 0; k < doctors.Count; k++)
        {
            if (doctors[k] == userDr)
            {
                Console.WriteLine(k);
                isMatched2 = true;
            }
        }
        // 10. add text that tells the user if they put in text that isn't in the list
        if (isMatched2 == false)
            {
                Console.WriteLine("There are no doctors by that name in this building.");
            }

        // 11. Create list of strings with at least two identical strings.
        // Create a foreach loop that evaluates each item in the list,
        // displays a message showing the string and whether or not
        // it has already appeared in the list. CONTAINS

        List<string> animals = new List<string>() {"cat", "bear", "sheep", "deer", "bear", "hippopotamus"};
        List<string> singleAnimals = new List<string>();

        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
            if (!singleAnimals.Contains(animal))
            {
                singleAnimals.Add(animal);
                Console.WriteLine("This animal hasn't yet appeared in the Animals list.");
            }
            else
            {
                Console.WriteLine("This animal has already appeared in the Animals list.");
            }
        }
        Console.ReadLine();
    }
}

