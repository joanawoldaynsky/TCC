using System;

public class ExponentialNumbers
{
    public static double Power(double baseValue, int exponent)
{
    double result = 1;
    int exp = Math.Abs(exponent);
    
    while (exp > 0)
    {
        if (exp % 2 == 1)
        {
            result *= baseValue;
        }
        baseValue *= baseValue;
        exp /= 2;
    }
    
    return exponent < 0 ? 1 / result : result;
}


    public static void Main(string[] args)
    {
        double baseValue = 2.0;
        int exponent = 10;
        Console.WriteLine($"{baseValue}^{exponent} = {Power(baseValue, exponent)}");
    }
}
