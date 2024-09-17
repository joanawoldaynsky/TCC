using System;

public class InsertionSort
{
    public static void InsertionSortMethod(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // Move elements of arr[0..i-1], that are greater than key,
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        InsertionSortMethod(arr);
        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
