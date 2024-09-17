public class teste1 {
    public static boolean isPalindrome(int number) {
        int originalNumber = number;
        int reversedNumber = 0;
        
        while (number != 0) {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        
        return originalNumber == reversedNumber;
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
