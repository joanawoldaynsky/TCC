using System;
using System.Collections.Generic;

class Permutacao
{
    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 1, 2, 3 };
        List<List<int>> result = new List<List<int>>();
        Permute(arr, 0, result);
        foreach (var perm in result)
        {
            Console.WriteLine(string.Join(", ", perm));
        }
    }

    static void Permute(List<int> arr, int index, List<List<int>> result)
    {
        if (index == arr.Count - 1)
        {
            result.Add(new List<int>(arr));
        }
        else
        {
            for (int i = index; i < arr.Count; i++)
            {
                List<int> swapped = new List<int>(arr);
                int temp = swapped[index];
                swapped[index] = swapped[i];
                swapped[i] = temp;
                Permute(swapped, index + 1, result);
            }
        }
    }
}
