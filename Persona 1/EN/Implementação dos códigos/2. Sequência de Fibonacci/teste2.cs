using System;

class Fibonacci
{
    static void Main()
    {
        int n = 50; // Example
        long a = 0, b = 1;
        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            long next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
    }
}
