using System;
using System.Numerics;

class Exponential
{
    static void Main()
    {
        BigInteger baseNum = 2;
        int exponent = 1000;
        BigInteger result = BigInteger.Pow(baseNum, exponent);

        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}
