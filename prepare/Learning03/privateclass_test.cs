using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;

    }
    public Fraction(int denom, int num)
    {
        _top = num;
        _bottom = denom;

    }
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
        Console.WriteLine(top);
    }

    public int GettBottom()
    {
        return _bottom;
    }
    
        public void SetBottom(int bottom)
    {
        _bottom = bottom;
        Console.WriteLine();
    }

    public string GetFractionString()
    {

        string text = $"{_top}/{_bottom}";

        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top /  (double)_bottom;
 
    }

}