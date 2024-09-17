import java.util.ArrayList;
import java.util.List;

public class teste2 {
    public static void main(String[] args) {
        List<Integer> arr = List.of(1, 2, 3);
        List<List<Integer>> result = new ArrayList<>();
        permute(arr, 0, result);
        System.out.println(result);
    }

    private static void permute(List<Integer> arr, int index, List<List<Integer>> result) {
        if (index == arr.size() - 1) {
            result.add(new ArrayList<>(arr));
        } else {
            for (int i = index; i < arr.size(); i++) {
                List<Integer> swapped = new ArrayList<>(arr);
                java.util.Collections.swap(swapped, index, i);
                permute(swapped, index + 1, result);
            }
        }
    }
}
