import java.math.BigInteger;

public class teste3 {
    // Função para calcular a^b usando exponenciação rápida
    public static BigInteger power(BigInteger a, BigInteger b) {
        BigInteger result = BigInteger.ONE;
        while (b.compareTo(BigInteger.ZERO) > 0) {
            if (b.and(BigInteger.ONE).equals(BigInteger.ONE)) {
                result = result.multiply(a);
            }
            a = a.multiply(a);
            b = b.shiftRight(1);
        }
        return result;
    }

    public static void main(String[] args) {
        BigInteger base = new BigInteger("3");
        BigInteger exponent = new BigInteger("1000");
        BigInteger result = power(base, exponent);
        System.out.println(base + "^" + exponent + " = " + result);
    }
}
