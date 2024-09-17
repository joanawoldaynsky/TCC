public class teste3 {
    public static void main(String[] args) {
        int n = 50; // Número para calcular a sequência de Fibonacci
        long[] fibCache = new long[n + 1];
        System.out.println(fibonacci(n, fibCache));
    }

    public static long fibonacci(int n, long[] fibCache) {
        if (n <= 1) {
            return n;
        }
        if (fibCache[n] != 0) {
            return fibCache[n];
        }
        fibCache[n] = fibonacci(n - 1, fibCache) + fibonacci(n - 2, fibCache);
        return fibCache[n];
    }
}
