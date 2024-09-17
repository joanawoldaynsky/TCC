using System;
using System.Collections.Generic;

class Permutation
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3 };
        List<List<int>> result = new List<List<int>>();
        Permute(numbers, 0, result);

        foreach (var perm in result)
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    static void Permute(List<int> arr, int k, List<List<int>> result)
    {
        if (k == arr.Count)
        {
            result.Add(new List<int>(arr));
        }
        else
        {
            for (int i = k; i < arr.Count; i++)
            {
                Swap(arr, i, k);
                Permute(arr, k + 1, result);
                Swap(arr, i, k);
            }
        }
    }

    static void Swap(List<int> arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
