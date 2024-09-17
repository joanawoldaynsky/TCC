import java.util.ArrayList;
import java.util.List;

public class teste2 {
    public static void main(String[] args) {
        String str = "ABC";
        List<String> result = new ArrayList<>();
        permute(str, 0, str.length() - 1, result);
        
        for (String s : result) {
            System.out.println(s);
        }
    }

    private static void permute(String str, int l, int r, List<String> result) {
        if (l == r) {
            result.add(str);
        } else {
            for (int i = l; i <= r; i++) {
                str = swap(str, l, i);
                permute(str, l + 1, r, result);
                str = swap(str, l, i); // backtrack
            }
        }
    }

    private static String swap(String str, int i, int j) {
        char temp;
        char[] charArray = str.toCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return String.valueOf(charArray);
    }
}
