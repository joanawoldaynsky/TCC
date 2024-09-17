import java.util.ArrayList;
import java.util.List;

public class teste1 {
    public static void main(String[] args) {
        String str = "ABC";
        List<String> permutations = new ArrayList<>();
        permute(str, 0, str.length() - 1, permutations);
        System.out.println(permutations);
    }

    private static void permute(String str, int l, int r, List<String> permutations) {
        if (l == r) {
            permutations.add(str);
        } else {
            for (int i = l; i <= r; i++) {
                str = swap(str, l, i);
                permute(str, l + 1, r, permutations);
                str = swap(str, l, i); // backtrack
            }
        }
    }

    private static String swap(String a, int i, int j) {
        char temp;
        char[] charArray = a.toCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return String.valueOf(charArray);
    }
}
