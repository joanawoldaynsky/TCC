using System;

class Fibonacci {
    static void Main() {
        int n = 10; // number of terms to display
        for (int i = 0; i < n; i++) {
            Console.Write(FibonacciSequence(i) + " ");
        }
    }

    static int FibonacciSequence(int n) {
        if (n <= 1) {
            return n;
        }
        return FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
    }
}
