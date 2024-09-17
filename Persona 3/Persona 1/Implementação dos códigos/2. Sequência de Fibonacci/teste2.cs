using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        int n = 50; // Exemplo
        BigInteger a = 0, b = 1;
        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            BigInteger next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
    }
}
