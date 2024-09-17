using System;

public class Fibonacci {
    public static void Main(string[] args) {
        int n = 10; // For example
        Console.WriteLine(Fib(n));
    }

    public static int Fib(int n) {
        if (n <= 1) {
            return n;
        }

        int[] fibArray = new int[n + 1];
        fibArray[0] = 0;
        fibArray[1] = 1;

        for (int i = 2; i <= n; i++) {
            fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
        }

        return fibArray[n];
    }
}
