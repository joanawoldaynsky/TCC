import java.math.BigDecimal;
import java.math.MathContext;

public class teste2 {
    public static BigDecimal power(BigDecimal base, int exponent) {
        BigDecimal result = BigDecimal.ONE;
        for (int i = 0; i < exponent; i++) {
            result = result.multiply(base, MathContext.DECIMAL128);
        }
        return result;
    }

    public static void main(String[] args) {
        BigDecimal base = new BigDecimal("2.0");
        int exponent = 10;
        BigDecimal result = power(base, exponent);
        System.out.println("2.0^10 = " + result);
    }
}
