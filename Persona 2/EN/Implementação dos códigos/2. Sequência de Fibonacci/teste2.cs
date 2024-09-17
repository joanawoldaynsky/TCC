using System;

class Fibonacci {
    static void Main() {
        int n = 10; // Example: the first 10 Fibonacci numbers
        PrintFibonacci(n);
    }

    static void PrintFibonacci(int n) {
        if (n <= 0) return;

        long a = 0, b = 1;
        Console.Write(a);

        for (int i = 1; i < n; i++) {
            Console.Write(" " + b);
            long next = a + b;
            a = b;
            b = next;
        }
    }
}
