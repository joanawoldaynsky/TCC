using System;

public class Exponential
{
    public static double Power(double base, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        double half = Power(base, exponent / 2);
        if (exponent % 2 == 0)
        {
            return half * half;
        }
        else
        {
            if (exponent > 0)
            {
                return base * half * half;
            }
            else
            {
                return (half * half) / base;
            }
        }
    }

    public static void Main(string[] args)
    {
        double baseNum = 2.0;
        int exponent = 10;
        Console.WriteLine($"{baseNum}^{exponent} = {Power(baseNum, exponent)}");
    }
}
