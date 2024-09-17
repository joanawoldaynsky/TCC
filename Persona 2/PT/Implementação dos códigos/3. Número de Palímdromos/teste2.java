public class teste2 {
    public static void main(String[] args) {
        int start = 100; // Início do intervalo
        int end = 200; // Fim do intervalo
        int count = 0;

        for (int i = start; i <= end; i++) {
            if (isPalindrome(i)) {
                count++;
            }
        }

        System.out.println("Número de palíndromos: " + count);
    }

    public static boolean isPalindrome(int number) {
        String str = Integer.toString(number);
        int len = str.length();
        for (int i = 0; i < len / 2; i++) {
            if (str.charAt(i) != str.charAt(len - 1 - i)) {
                return false;
            }
        }
        return true;
    }
}
