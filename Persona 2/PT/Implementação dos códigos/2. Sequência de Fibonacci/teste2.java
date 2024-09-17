import java.util.HashMap;
import java.util.Map;

public class teste2 {
    private Map<Integer, Long> memo = new HashMap<>();

    public long fib(int n) {
        if (n <= 1) {
            return n;
        }
        if (memo.containsKey(n)) {
            return memo.get(n);
        }
        long result = fib(n - 1) + fib(n - 2);
        memo.put(n, result);
        return result;
    }

    public static void main(String[] args) {
        teste2 fibonacci = new teste2();
        int n = 50; // Você pode mudar o valor de n para testar
        System.out.println("Fibonacci of " + n + " is " + fibonacci.fib(n));
    }
}
