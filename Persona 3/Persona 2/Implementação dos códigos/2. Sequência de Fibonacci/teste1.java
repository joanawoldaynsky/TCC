import java.math.BigInteger;


public class teste1 {
    public static void main(String[] args) {
        int n = 10; // Example: the first 10 Fibonacci numbers
        printFibonacciBigInt(n);
    }

    public static void printFibonacciBigInt(int n) {
        if (n <= 0) return;
    
        BigInteger a = BigInteger.ZERO, b = BigInteger.ONE;
        System.out.print(a);
    
        for (int i = 1; i < n; i++) {
            System.out.print(" " + b);
            BigInteger next = a.add(b);
            a = b;
            b = next;
        }
    }
}
