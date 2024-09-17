import java.math.BigInteger;
import java.util.Scanner;

public class teste2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a base: ");
        BigInteger base = new BigInteger(scanner.nextLine());

        System.out.print("Digite o expoente: ");
        int expoente = scanner.nextInt();

        BigInteger resultado = base.pow(expoente);

        System.out.println("Resultado: " + resultado.toString());

        scanner.close();
    }
}
