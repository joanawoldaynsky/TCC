import java.util.ArrayList;
import java.util.List;

public class teste1 {
    public static void main(String[] args) {
        List<Integer> arr = new ArrayList<>(List.of(1, 2, 3));  // Use ArrayList para modificar in-place
        List<List<Integer>> result = new ArrayList<>();
        permute(arr, 0, result);
        System.out.println(result);
    }

    private static void permute(List<Integer> arr, int index, List<List<Integer>> result) {
        if (index == arr.size() - 1) {
            result.add(new ArrayList<>(arr)); // Adiciona uma cópia da permutação final
        } else {
            for (int i = index; i < arr.size(); i++) {
                java.util.Collections.swap(arr, index, i);  // Troca in-place
                permute(arr, index + 1, result);
                java.util.Collections.swap(arr, index, i);  // Desfaz a troca
            }
        }
    }
}
