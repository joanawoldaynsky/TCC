using System;
using System.Collections.Generic;

class FibonacciMemoization
{
    private Dictionary<int, long> memo = new Dictionary<int, long>();

    public long Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }
        long result = Fib(n - 1) + Fib(n - 2);
        memo[n] = result;
        return result;
    }

    static void Main(string[] args)
    {
        FibonacciMemoization fibonacci = new FibonacciMemoization();
        int n = 50; // Você pode mudar o valor de n para testar
        Console.WriteLine("Fibonacci of " + n + " is " + fibonacci.Fib(n));
    }
}
