public class teste3 {
    public static void main(String[] args) {
        int n = 10; // Por exemplo, calcular o 10º número de Fibonacci
        System.out.println(fib(n));
    }

    public static int fib(int n) {
        if (n <= 1) {
            return n;
        }

        int prev1 = 0, prev2 = 1;
        for (int i = 2; i <= n; i++) {
            int current = prev1 + prev2;
            prev1 = prev2;
            prev2 = current;
        }

        return prev2;
    }
}
