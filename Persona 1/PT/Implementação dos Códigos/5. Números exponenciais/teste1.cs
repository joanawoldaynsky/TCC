using System;

class Exponential
{
    static void Main()
    {
        int baseNum = 2;
        int exponent = 3;
        double result = Math.Pow(baseNum, exponent);

        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}
