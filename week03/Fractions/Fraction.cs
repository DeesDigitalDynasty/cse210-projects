using System;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters for both top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Representation MEthods

    // Return fraction formatted as strings
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value from division
    public double GetDecimalValue()
    {
        return(double)_top / _bottom;
    }
}