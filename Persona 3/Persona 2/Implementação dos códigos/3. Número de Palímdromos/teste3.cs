public class PalindromeCounter {
    public static int CountPalindromes(string s) {
        int count = 0;
        int n = s.Length;
        
        for (int center = 0; center < 2 * n - 1; center++) {
            int left = center / 2;
            int right = left + center % 2;
            
            while (left >= 0 && right < n && s[left] == s[right]) {
                count++;
                left--;
                right++;
            }
        }
        
        return count;
    }

    public static void Main(string[] args) {
        string s = "ababa";
        Console.WriteLine("Number of palindromes: " + CountPalindromes(s));
    }
}
