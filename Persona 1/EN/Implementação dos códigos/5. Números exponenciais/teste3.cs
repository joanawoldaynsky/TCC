using System;

public class Exponential
{
    public static void Main(string[] args)
    {
        int baseNum = 2;
        int exponent = 10;
        Console.WriteLine($"{baseNum}^{exponent} = {Power(baseNum, exponent)}");
    }

    public static long Power(int baseNum, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        long halfPower = Power(baseNum, exponent / 2);
        if (exponent % 2 == 0)
        {
            return halfPower * halfPower;
        }
        else
        {
            return baseNum * halfPower * halfPower;
        }
    }
}
