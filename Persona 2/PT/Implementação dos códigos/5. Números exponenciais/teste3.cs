using System;

public class ExponentialNumbers
{
    public static double Power(double baseValue, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        double half = Power(baseValue, exponent / 2);
        if (exponent % 2 == 0)
        {
            return half * half;
        }
        else
        {
            if (exponent > 0)
            {
                return baseValue * half * half;
            }
            else
            {
                return (half * half) / baseValue;
            }
        }
    }

    public static void Main(string[] args)
    {
        double baseValue = 2.0;
        int exponent = 10;
        Console.WriteLine($"{baseValue}^{exponent} = {Power(baseValue, exponent)}");
    }
}
