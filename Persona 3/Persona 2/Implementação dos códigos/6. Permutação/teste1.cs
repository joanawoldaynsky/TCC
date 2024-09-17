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
            result.Add(new List<int>(arr)); // Adiciona uma cópia da permutação
        }
        else
        {
            for (int i = index; i < arr.Count; i++)
            {
                Swap(arr, index, i); // Troca in-place
                Permute(arr, index + 1, result); // Chamada recursiva
                Swap(arr, index, i); // Desfaz a troca (backtracking)
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
