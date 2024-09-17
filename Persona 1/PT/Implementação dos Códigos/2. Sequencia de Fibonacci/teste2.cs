// Fibonacci.cs
using System;

class Fibonacci
{
    public static long FibonacciSequence(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Input should be a positive integer");
        }
        else if (n == 1)
        {
            return 0;
        }
        else if (n == 2)
        {
            return 1;
        }
        else
        {
            long a = 0, b = 1;
            for (int i = 3; i <= n; i++)
            {
                long next = a + b;
                a = b;
                b = next;
            }
            return b;
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine($"Fibonacci({n}) = {FibonacciSequence(n)}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
