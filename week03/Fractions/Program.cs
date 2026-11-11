using System;

class Program
{
    static void Main(string[] args)
    {
       // Constructor test 1
       Fraction f1 = new Fraction();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());

       // Constructor test 2
       Fraction f2 = new Fraction(5);
       Console.WriteLine(f2.GetFractionString());
       Console.WriteLine(f2.GetDecimalValue());
       
       // Constructor test 3
       Fraction f3 = new Fraction(3, 4);
       Console.WriteLine(f3.GetFractionString());
       Console.WriteLine(f3.GetDecimalValue());

       // Constructor test 3 with another fraction
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test Getters and Setters
        Console.WriteLine("\nTesting Getters and Setters on f1:");
        f1.SetTop(2);
        f1.SetBottom(5);
        Console.WriteLine($"New Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"New Decimal: {f1.GetDecimalValue()}");
    }
}