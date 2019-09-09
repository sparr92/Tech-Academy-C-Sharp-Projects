using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 5, 3, 10, 2, 6, 4 };
        Console.WriteLine("Please enter a number to divide by each number in my list: ");
        try
        {
            foreach (int number in numbers)
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                int dividend = number / userNum;
                Console.WriteLine(number + " divided by " + userNum + " equals " + dividend);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not enter zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("You have emerged from the try/catch block");
            Console.ReadLine();
        }
    }   
}
