import java.util.ArrayList;
import java.util.List;

public class teste2 {
    public static List<String> permute(String str) {
        List<String> result = new ArrayList<>();
        permuteHelper(str, "", result);
        return result;
    }

    private static void permuteHelper(String str, String chosen, List<String> result) {
        if (str.isEmpty()) {
            result.add(chosen);
        } else {
            for (int i = 0; i < str.length(); i++) {
                char c = str.charAt(i);
                String remaining = str.substring(0, i) + str.substring(i + 1);
                permuteHelper(remaining, chosen + c, result);
            }
        }
    }

    public static void main(String[] args) {
        String input = "abc";
        List<String> permutations = permute(input);
        for (String perm : permutations) {
            System.out.println(perm);
        }
    }
}
