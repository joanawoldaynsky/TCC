using System;
using System.Collections.Generic;

public class Permutacao {
    public static void Main(string[] args) {
        List<int> nums = new List<int>{1, 2, 3};
        List<List<int>> resultados = Permutar(nums);
        foreach (var lista in resultados) {
            Console.WriteLine(string.Join(", ", lista));
        }
    }

    public static List<List<int>> Permutar(List<int> nums) {
        List<List<int>> resultados = new List<List<int>>();
        Backtrack(nums, new List<int>(), resultados);
        return resultados;
    }

    private static void Backtrack(List<int> nums, List<int> tempList, List<List<int>> resultados) {
        if (tempList.Count == nums.Count) {
            resultados.Add(new List<int>(tempList));
        } else {
            foreach (var num in nums) {
                if (tempList.Contains(num)) continue; // elemento já usado
                tempList.Add(num);
                Backtrack(nums, tempList, resultados);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
