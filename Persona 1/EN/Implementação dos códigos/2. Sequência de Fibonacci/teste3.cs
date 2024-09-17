// Fibonacci sequence with memoization in C#
using System;
using System.Collections.Generic;

class Fibonacci {
    private static Dictionary<int, int> memo = new Dictionary<int, int>();

    public static int FibonacciSequence(int n) {
        if (memo.ContainsKey(n)) {
            return memo[n];
        }
        if (n <= 1) {
            return n;
        }
        int result = FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
        memo[n] = result;
        return result;
    }

    static void Main(string[] args) {
        int n = 10;
        Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciSequence(n));
    }
}
