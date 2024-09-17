import java.util.ArrayList;
import java.util.List;

public class teste2 {
    public static void main(String[] args) {
        List<Integer> nums = new ArrayList<>();
        nums.add(1);
        nums.add(2);
        nums.add(3);
        List<List<Integer>> resultados = permutar(nums);
        for (List<Integer> lista : resultados) {
            System.out.println(lista);
        }
    }

    public static List<List<Integer>> permutar(List<Integer> nums) {
        List<List<Integer>> resultados = new ArrayList<>();
        backtrack(nums, new ArrayList<>(), resultados);
        return resultados;
    }

    private static void backtrack(List<Integer> nums, List<Integer> tempList, List<List<Integer>> resultados) {
        if (tempList.size() == nums.size()) {
            resultados.add(new ArrayList<>(tempList));
        } else {
            for (int i = 0; i < nums.size(); i++) {
                if (tempList.contains(nums.get(i))) continue; // elemento já usado
                tempList.add(nums.get(i));
                backtrack(nums, tempList, resultados);
                tempList.remove(tempList.size() - 1);
            }
        }
    }
}
