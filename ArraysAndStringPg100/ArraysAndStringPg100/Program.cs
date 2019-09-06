using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] ages = new int[] { 4, 26, 35 };

        Console.WriteLine("Select 1, 2, or 3 to retrieve the age of a member of the household, listed in ascending order:");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPicked = false;

        while (!isPicked)
        {

            switch (num)
            {
                case 1:
                    Console.WriteLine("You picked household member number 1. That household member is " + ages[0] + " years old.");
                    isPicked = true;
                    break;

                case 2:
                    Console.WriteLine("You picked household member number 2. That household member is " + ages[1] + " years old.");
                    isPicked = true;
                    break;


                case 3:
                    Console.WriteLine("You picked household member number 3. That household member is " + ages[2] + " years old.");
                    isPicked = true;
                    break;

                default:
                    Console.WriteLine("I said 1, 2, or 3! We only have 3 household members. Pick again!");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }


        string[] names = new string[] { "Momo", "Sarah", "Nathan" };

        Console.WriteLine("Select 1, 2, or 3 to retrieve the name of a member of the household, listed by age in ascending order:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        bool isPicked2 = false;

        while (!isPicked2)
        {

            switch (num2)
            {
                case 1:
                    Console.WriteLine("You picked household member number 1. That household member is " + names[0] + ".");
                    isPicked2 = true;
                    break;

                case 2:
                    Console.WriteLine("You picked household member number 2. That household member is " + names[1] + ".");
                    isPicked2 = true;
                    break;


                case 3:
                    Console.WriteLine("You picked household member number 3. That household member is " + names[2] + ".");
                    isPicked2 = true;
                    break;

                default:
                    Console.WriteLine("I said 1, 2, or 3! We only have 3 household members. Pick again!");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;


            }
        }

        List<string> strList = new List<string>();
        strList.Add("temptations");
        strList.Add("sushi");
        strList.Add("ice cream");

        Console.WriteLine("Select 1, 2, or 3 to retrieve the favorite food of a member of the household, listed by age in ascending order:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        bool isPicked3 = false;

        while (!isPicked3)
        {

            switch (num3)
            {
                case 1:
                    Console.WriteLine("You picked household member number 1. That household member's favorite food is " + strList[0] + ".");
                    isPicked3 = true;
                    break;

                case 2:
                    Console.WriteLine("You picked household member number 2. That household member's favorite food is " + strList[1] + ".");
                    isPicked3 = true;
                    break;


                case 3:
                    Console.WriteLine("You picked household member number 3. That household member's favorite food is " + strList[2] + ".");
                    isPicked3 = true;
                    break;

                default:
                    Console.WriteLine("I said 1, 2, or 3! We only have 3 household members. Pick again!");
                    num3 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        Console.Read();
    }
}
