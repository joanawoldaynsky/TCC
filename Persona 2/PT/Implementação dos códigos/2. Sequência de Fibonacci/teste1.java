public class teste1 {
    public static void main(String[] args) {
        int n = 10; // Quantidade de termos da sequência de Fibonacci
        for (int i = 0; i < n; i++) {
            System.out.print(fibonacci(i) + " ");
        }
    }

    public static int fibonacci(int n) {
        if (n <= 1) {
            return n;
        }
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
}
