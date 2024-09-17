public class teste2 {
    public static void main(String[] args) {
        int n = 10; // Example: the first 10 Fibonacci numbers
        printFibonacci(n);
    }

    public static void printFibonacci(int n) {
        if (n <= 0) return;

        long a = 0, b = 1;
        System.out.print(a);

        for (int i = 1; i < n; i++) {
            System.out.print(" " + b);
            long next = a + b;
            a = b;
            b = next;
        }
    }
}
