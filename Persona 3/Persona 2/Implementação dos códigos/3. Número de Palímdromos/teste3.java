public class teste3 {
    
    public static int countPalindromes(String s) {
        int count = 0;
        for (int i = 0; i < s.length(); i++) {
            // Contar palíndromos com centro em um único caractere
            count += expandFromCenter(s, i, i);
            // Contar palíndromos com centro em dois caracteres
            count += expandFromCenter(s, i, i + 1);
        }
        return count;
    }
    
    private static int expandFromCenter(String s, int left, int right) {
        int count = 0;
        while (left >= 0 && right < s.length() && s.charAt(left) == s.charAt(right)) {
            count++;
            left--;
            right++;
        }
        return count;
    }
    

    public static void main(String[] args) {
        String s = "ababa";
        System.out.println("Number of palindromes: " + countPalindromes(s));
    }
}
