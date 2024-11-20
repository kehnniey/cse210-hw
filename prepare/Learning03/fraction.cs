using System;

public class Fraction
{
    // Private attributes
    private int _numerator;
    private int _denominator;

    // Constructors
    public Fraction() // Default constructor initializes to 1/1
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator) // Constructor initializes to numerator/1
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator) // Constructor for numerator/denominator
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set 
        { 
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            _denominator = value; 
        }
    }

    // Methods
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
