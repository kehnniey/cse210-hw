using System;

class Program
{
    static void Main(string[] args)
    {
        // Test fractions with all constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Display fractions and their decimal values
        DisplayFractionDetails(fraction1);
        DisplayFractionDetails(fraction2);
        DisplayFractionDetails(fraction3);
        DisplayFractionDetails(fraction4);

        // Test getters and setters
        Fraction testFraction = new Fraction(2, 5);
        Console.WriteLine("Initial:");
        DisplayFractionDetails(testFraction);

        // Modify using setters
        testFraction.Numerator = 7;
        testFraction.Denominator = 8;
        Console.WriteLine("Modified:");
        DisplayFractionDetails(testFraction);
    }

    static void DisplayFractionDetails(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}
