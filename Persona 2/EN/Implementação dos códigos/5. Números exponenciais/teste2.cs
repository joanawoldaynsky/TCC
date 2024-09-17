using System;
using System.Numerics;

class Exponential {
    public static BigInteger Power(BigInteger baseValue, int exponent) {
        BigInteger result = BigInteger.One;
        for (int i = 0; i < exponent; i++) {
            result *= baseValue;
        }
        return result;
    }

    public static void Main(string[] args) {
        BigInteger baseValue = new BigInteger(2);
        int exponent = 10;
        BigInteger result = Power(baseValue, exponent);
        Console.WriteLine($"2^{exponent} = {result}");
    }
}
