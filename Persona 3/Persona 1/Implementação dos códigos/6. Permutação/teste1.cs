using System;
using System.Collections.Generic;

class Permutation
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3 };
        foreach (var perm in GetPermutations(numbers, 0))
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    static IEnumerable<List<int>> GetPermutations(List<int> arr, int k)
    {
        if (k == arr.Count)
        {
            yield return new List<int>(arr);
        }
        else
        {
            for (int i = k; i < arr.Count; i++)
            {
                Swap(arr, i, k);
                foreach (var perm in GetPermutations(arr, k + 1))
                {
                    yield return perm;
                }
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
