public class teste3 {
    // Função para calcular a^b usando exponenciação rápida
    public static long power(long a, long b) {
        long result = 1;
        while (b > 0) {
            if ((b & 1) == 1) {
                result *= a;
            }
            a *= a;
            b >>= 1;
        }
        return result;
    }

    public static void main(String[] args) {
        long base = 3;
        long exponent = 10;
        long result = power(base, exponent);
        System.out.println(base + "^" + exponent + " = " + result);
    }
}
