using System;
using System.Numerics;

class Exponential {
    public static BigInteger Power(BigInteger baseValue, int exponent) {
        BigInteger result = BigInteger.One;
        while (exponent > 0) {
            if ((exponent & 1) == 1) {
                result *= baseValue;
            }
            baseValue *= baseValue; // Eleva ao quadrado
            exponent >>= 1; // Divide o expoente por 2
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
