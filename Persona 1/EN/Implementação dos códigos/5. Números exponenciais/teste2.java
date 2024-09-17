import java.math.BigInteger;

public class teste2 {
    public static void main(String[] args) {
        int base = 2;
        int exponent = 1000; // you can change this value to test different exponents
        BigInteger result = BigInteger.valueOf(base).pow(exponent);
        System.out.println("Result: " + result);
    }
}
