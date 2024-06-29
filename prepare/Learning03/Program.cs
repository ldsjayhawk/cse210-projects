using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fraction = new Fraction();
        // Fraction.top = 2;
        // Fraction.bottom = 3;

        Fraction myfraction = new Fraction();
        myfraction.SetTop(1);
        Console.WriteLine(myfraction.GetTop());

        myfraction.SetBottom(4);
        Console.WriteLine(myfraction.GetBottom());

        Console.WriteLine(myfraction.GetFractionString());
        
        double decimalValue = myfraction.GetDecimalValue();
        Console.WriteLine(decimalValue);    
    }
}
