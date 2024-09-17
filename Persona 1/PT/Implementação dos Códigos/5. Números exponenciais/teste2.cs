using System;
using System.Numerics;

class Exponential
{
    static void Main()
    {
        Console.Write("Digite a base: ");
        BigInteger baseNum = BigInteger.Parse(Console.ReadLine());

        Console.Write("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        BigInteger resultado = BigInteger.Pow(baseNum, expoente);

        Console.WriteLine("Resultado: " + resultado);
    }
}
