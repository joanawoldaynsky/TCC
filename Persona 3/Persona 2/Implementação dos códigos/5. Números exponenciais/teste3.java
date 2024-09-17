public class teste3 {
    public static double power(double base, int exponent) {
        double result = 1;
        int exp = Math.abs(exponent);
        while (exp > 0) {
            if (exp % 2 == 1) {
                result *= base;
            }
            base *= base;
            exp /= 2;
        }
        return exponent < 0 ? 1 / result : result;
    }
    

    public static void main(String[] args) {
        double base = 2.0;
        int exponent = 10;
        System.out.println(base + "^" + exponent + " = " + power(base, exponent));
    }
}
