public class teste1 {
    public static boolean isPalindrome(int number) {
        String str = Integer.toString(number);
        String reversedStr = new StringBuilder(str).reverse().toString();
        return str.equals(reversedStr);
    }
    
    public static void main(String[] args) {
        int number = 121; // você pode testar com outros números
        if (isPalindrome(number)) {
            System.out.println(number + " é um palíndromo.");
        } else {
            System.out.println(number + " não é um palíndromo.");
        }
    }
}
