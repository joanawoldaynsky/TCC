public class teste3 {
    public static double power(double base, int exponent) {
        if (exponent == 0) {
            return 1;
        }
        double half = power(base, exponent / 2);
        if (exponent % 2 == 0) {
            return half * half;
        } else {
            if (exponent > 0) {
                return base * half * half;
            } else {
                return (half * half) / base;
            }
        }
    }

    public static void main(String[] args) {
        double base = 2.0;
        int exponent = 10;
        System.out.println(base + "^" + exponent + " = " + power(base, exponent));
    }
}
