using System;

public class InsertionSort
{
    public static void InsertionSortArray(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    public static void Main()
    {
        int[] array = { 12, 11, 13, 5, 6 };
        InsertionSortArray(array);
        Console.WriteLine("Sorted array:");
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }
}
