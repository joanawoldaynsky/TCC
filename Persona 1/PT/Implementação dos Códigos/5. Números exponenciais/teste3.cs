using System;

public class Exponential
{
    // Função para calcular a^b usando exponenciação rápida
    public static long Power(long a, long b)
    {
        long result = 1;
        while (b > 0)
        {
            if ((b & 1) == 1)
            {
                result *= a;
            }
            a *= a;
            b >>= 1;
        }
        return result;
    }

    public static void Main()
    {
        long baseNum = 3;
        long exponent = 10;
        long result = Power(baseNum, exponent);
        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}
