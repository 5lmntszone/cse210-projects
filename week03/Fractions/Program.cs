using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);

        Console.WriteLine($"{f1} {f2} {f3}");

        Fraction f = new Fraction();

        Console.WriteLine($"Original fraction: {f}");

        f.SetTop(5);
        f.SetBottom(8);

        Console.WriteLine("\nUpdated Values:");
        Console.WriteLine($"Top: {f.GetTop()}");
        Console.WriteLine($"Bottom: {f.GetBottom()}");

        
    }
}