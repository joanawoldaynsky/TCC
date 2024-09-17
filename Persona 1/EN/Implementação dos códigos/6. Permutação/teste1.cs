using System;
using System.Collections.Generic;

class Permutations
{
    static void Main()
    {
        List<int> nums = new List<int> { 1, 2, 3 };
        List<List<int>> result = new List<List<int>>();
        Permute(nums, 0, result);
        foreach (var perm in result)
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    static void Permute(List<int> nums, int start, List<List<int>> result)
    {
        if (start >= nums.Count)
        {
            result.Add(new List<int>(nums));
            return;
        }
        for (int i = start; i < nums.Count; i++)
        {
            Swap(nums, start, i);
            Permute(nums, start + 1, result);
            Swap(nums, start, i);
        }
    }

    static void Swap(List<int> nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
