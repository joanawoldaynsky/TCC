import java.math.BigDecimal;
import java.math.MathContext;

public class teste1 {
    public static BigDecimal fastPower(BigDecimal base, int exponent) {
        BigDecimal result = BigDecimal.ONE;
        BigDecimal currentBase = base;

        while (exponent > 0) {
            if (exponent % 2 == 1) {  // Se o expoente for ímpar
                result = result.multiply(currentBase, MathContext.DECIMAL128);
            }
            currentBase = currentBase.multiply(currentBase, MathContext.DECIMAL128);  // Base ao quadrado
            exponent /= 2;
        }

        return result;
    }

    public static void main(String[] args) {
        BigDecimal base = new BigDecimal("2.0");
        int exponent = 10;
        BigDecimal result = fastPower(base, exponent);
        System.out.println("2.0^10 = " + result);
    }
}
