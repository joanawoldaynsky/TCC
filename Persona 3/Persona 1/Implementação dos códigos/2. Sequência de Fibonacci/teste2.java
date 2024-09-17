import java.math.BigInteger;

public class teste2 {
    public static void main(String[] args) {
        int n = 50; // Exemplo
        if (n < 1) {
            System.out.println("O valor de n deve ser maior que 0.");
            return;
        }

        BigInteger a = BigInteger.ZERO;
        BigInteger b = BigInteger.ONE;
        System.out.print(a + " " + b + " ");

        for (int i = 2; i < n; i++) {
            BigInteger next = a.add(b);
            System.out.print(next + " ");
            a = b;
            b = next;
        }
    }
}
