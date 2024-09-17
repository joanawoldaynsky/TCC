// Fibonacci.java
import java.util.Scanner;

public class teste1 {
    public static int fibonacci(int n) {
        if (n <= 0) {
            throw new IllegalArgumentException("Input should be a positive integer");
        } else if (n == 1) {
            return 0;
        } else if (n == 2) {
            return 1;
        } else {
            int a = 0, b = 1;
            for (int i = 3; i <= n; i++) {
                int next = a + b;
                a = b;
                b = next;
            }
            return b;
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int n = scanner.nextInt();
        try {
            System.out.println("Fibonacci(" + n + ") = " + fibonacci(n));
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        }
        scanner.close();
    }
}
