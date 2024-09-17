public class teste3 {
    public static void main(String[] args) {
        int base = 2;
        int exponent = 10;
        System.out.println(base + "^" + exponent + " = " + power(base, exponent));
    }

    public static long power(int base, int exponent) {
        if (exponent == 0) {
            return 1;
        }
        long halfPower = power(base, exponent / 2);
        if (exponent % 2 == 0) {
            return halfPower * halfPower;
        } else {
            return base * halfPower * halfPower;
        }
    }
}
