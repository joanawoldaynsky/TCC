import java.util.ArrayList;
import java.util.List;

public class teste1 {
    public static void main(String[] args) {
        List<Integer> nums = List.of(1, 2, 3);
        List<List<Integer>> result = new ArrayList<>();
        permute(nums, 0, result);
        for (List<Integer> perm : result) {
            System.out.println(perm);
        }
    }

    private static void permute(List<Integer> nums, int start, List<List<Integer>> result) {
        if (start >= nums.size()) {
            result.add(new ArrayList<>(nums));
            return;
        }
        for (int i = start; i < nums.size(); i++) {
            swap(nums, start, i);
            permute(nums, start + 1, result);
            swap(nums, start, i);
        }
    }

    private static void swap(List<Integer> nums, int i, int j) {
        int temp = nums.get(i);
        nums.set(i, nums.get(j));
        nums.set(j, temp);
    }
}
