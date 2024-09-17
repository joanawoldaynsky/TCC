import java.util.ArrayList;
import java.util.List;

public class teste3 {
    
    public static List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> result = new ArrayList<>();
        boolean[] used = new boolean[nums.length];
        backtrack(result, new ArrayList<>(), nums, used);
        return result;
    }
    
    private static void backtrack(List<List<Integer>> result, List<Integer> tempList, int[] nums, boolean[] used) {
        if (tempList.size() == nums.length) {
            result.add(new ArrayList<>(tempList));
        } else {
            for (int i = 0; i < nums.length; i++) {
                if (used[i]) continue; // Element already used, skip
                used[i] = true;
                tempList.add(nums[i]);
                backtrack(result, tempList, nums, used);
                used[i] = false;
                tempList.remove(tempList.size() - 1);
            }
        }
    }

    public static void main(String[] args) {
        int[] elements = {1, 2, 3};
        List<List<Integer>> permutations = permute(elements);
        for (List<Integer> p : permutations) {
            System.out.println(p);
        }
    }
}
