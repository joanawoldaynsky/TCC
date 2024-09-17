using System;
using System.Collections.Generic;

public class Permutations {
    public static IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        Backtrack(result, new List<int>(), nums);
        return result;
    }

    private static void Backtrack(IList<IList<int>> result, IList<int> tempList, int[] nums, bool[] used) {
    if (tempList.Count == nums.Length) {
        result.Add(new List<int>(tempList));
    } else {
        for (int i = 0; i < nums.Length; i++) {
            if (used[i]) continue; // Evita o Contains
            used[i] = true;
            tempList.Add(nums[i]);
            Backtrack(result, tempList, nums, used);
            used[i] = false;
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}


    public static void Main(string[] args) {
        int[] nums = { 1, 2, 3 };
        var permutations = Permute(nums);
        foreach (var perm in permutations) {
            Console.WriteLine(string.Join(", ", perm));
        }
    }
}
