import java.util.ArrayList;
import java.util.List;

public class teste1 {
    public static void main(String[] args) {
        List<Integer> numbers = new ArrayList<>();
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);
        
        List<List<Integer>> result = new ArrayList<>();
        permute(numbers, 0, result);
        
        for (List<Integer> perm : result) {
            System.out.println(perm);
        }
    }

    public static void permute(List<Integer> arr, int k, List<List<Integer>> result) {
        if (k == arr.size()) {
            result.add(new ArrayList<>(arr));
        } else {
            for (int i = k; i < arr.size(); i++) {
                java.util.Collections.swap(arr, i, k);
                permute(arr, k + 1, result);
                java.util.Collections.swap(arr, k, i);
            }
        }
    }
}
