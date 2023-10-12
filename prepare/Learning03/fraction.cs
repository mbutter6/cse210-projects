using System;

public class Fraction
{
    private int TopNumber { get; set; }

    private int BottomNumber { get; set; }

    //Constructor
    public Fraction()
    {
        TopNumber = 1;
        BottomNumber = 1;

    }

    public Fraction(int wholeNumber)
    {

        TopNumber = wholeNumber;
        BottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        TopNumber = top;
        BottomNumber = bottom;
    }

    public string GetFraction()
    {
        string text = $"{TopNumber}/{BottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)TopNumber / (double)BottomNumber;
    }

}

