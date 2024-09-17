public class teste2 {
    public static void main(String[] args) {
        int n = 50; // Example
        long a = 0, b = 1;
        System.out.print(a + " " + b + " ");

        for (int i = 2; i < n; i++) {
            long next = a + b;
            System.out.print(next + " ");
            a = b;
            b = next;
        }
    }
}
