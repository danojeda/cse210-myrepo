using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top =1;
        _bottom =1;
    }

    public Fraction(int denominator)
    {   
        _top = denominator;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }


    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString ()
    {
        return  _top.ToString() + '/' + _bottom.ToString(); 
    }

    public double GetDecimalValue()
    {
        double dTop = _top;
        double dBottom = _bottom;
        
        return dTop / dBottom;
    }


/*
Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.

Create a method called GetFractionString that returns the fraction in the form 3/4.
*/

}