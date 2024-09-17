using System;

public class Fibonacci {
    public static void Main(string[] args) {
        int n = 10; // Por exemplo
        Console.WriteLine(Fib(n));
    }

    public static int Fib(int n) {
        if (n <= 1) {
            return n;
        }

        int a = 0;
        int b = 1;
        int temp;

        for (int i = 2; i <= n; i++) {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}
