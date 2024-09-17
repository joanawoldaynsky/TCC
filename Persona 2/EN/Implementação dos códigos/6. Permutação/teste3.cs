using System;
using System.Collections.Generic;

public class Permutations
{
    public static IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        var current = new List<int>();
        var used = new bool[nums.Length];
        Backtrack(result, current, nums, used);
        return result;
    }

    private static void Backtrack(List<IList<int>> result, List<int> current, int[] nums, bool[] used)
    {
        if (current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            used[i] = true;
            current.Add(nums[i]);
            Backtrack(result, current, nums, used);
            used[i] = false;
            current.RemoveAt(current.Count - 1);
        }
    }

    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        var permutations = Permute(nums);
        foreach (var perm in permutations)
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }
}
