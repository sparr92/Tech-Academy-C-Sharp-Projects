using System;

struct Numbers {
    decimal Amount;
    public void GetAmount(decimal amt) {
        Amount = amt;
    }
    public void Print()
    {
        Console.WriteLine(Amount);
    }
};
public class Amount
{
    public static void Main(string[] args)
    {
        Numbers num1 = new Numbers();
        Numbers num2 = new Numbers();

        num1.GetAmount(3.38m);
        num2.GetAmount(5.689m);

        num1.Print();
        num2.Print();

        Console.ReadKey();
    }
}
