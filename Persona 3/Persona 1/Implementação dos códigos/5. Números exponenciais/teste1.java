import java.math.BigInteger;

public class teste1 {
    public static void main(String[] args) {
        BigInteger base = new BigInteger("2");
        int exponent = 3;
        BigInteger result = base.pow(exponent);

        System.out.println(base + "^" + exponent + " = " + result);
    }
}
