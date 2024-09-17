using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] elements = { 1, 2, 3 };
        var permutations = new List<List<int>>();
        Permute(elements, 0, permutations);
        foreach (var perm in permutations)
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    public static void Permute(int[] nums, int start, List<List<int>> result)
    {
        if (start == nums.Length)
        {
            result.Add(new List<int>(nums));
        }
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i);
                Permute(nums, start + 1, result);
                Swap(nums, start, i); // backtrack
            }
        }
    }

    private static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
