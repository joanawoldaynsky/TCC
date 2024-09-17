using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] elements = { 1, 2, 3 };
        var permutations = Permute(elements);
        foreach (var perm in permutations)
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    public static List<List<int>> Permute(int[] nums)
    {
        var result = new List<List<int>>();
        Backtrack(result, new List<int>(), nums);
        return result;
    }

    private static void Backtrack(List<List<int>> result, List<int> tempList, int[] nums)
    {
        if (tempList.Count == nums.Length)
        {
            result.Add(new List<int>(tempList));
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (tempList.Contains(nums[i])) continue; // Element already exists, skip
                tempList.Add(nums[i]);
                Backtrack(result, tempList, nums);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
