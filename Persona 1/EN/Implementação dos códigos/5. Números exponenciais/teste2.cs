using System;
using System.Numerics;

class ExponentialNumber
{
    static void Main()
    {
        int baseNum = 2;
        int exponent = 1000; // you can change this value to test different exponents
        BigInteger result = BigInteger.Pow(baseNum, exponent);
        Console.WriteLine("Result: " + result);
    }
}
