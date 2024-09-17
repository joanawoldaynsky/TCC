using System;

class Fibonacci {
    static void Main() {
        int n = 50; // Número para calcular a sequência de Fibonacci
        long[] fibCache = new long[n + 1];
        Console.WriteLine(FibonacciCalc(n, fibCache));
    }

    static long FibonacciCalc(int n, long[] fibCache) {
        if (n <= 1) {
            return n;
        }
        if (fibCache[n] != 0) {
            return fibCache[n];
        }
        fibCache[n] = FibonacciCalc(n - 1, fibCache) + FibonacciCalc(n - 2, fibCache);
        return fibCache[n];
    }
}
