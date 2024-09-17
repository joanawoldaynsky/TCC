using System;

class InsertionSort {
    public static void InsertionSortMethod(int[] arr) {
        for (int i = 1; i < arr.Length; i++) {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void Main(string[] args) {
        int[] data = {64, 34, 25, 12, 22, 11, 90};
        Console.WriteLine("Unsorted array:");
        foreach (int i in data) {
            Console.Write(i + " ");
        }
        InsertionSortMethod(data);
        Console.WriteLine("\nSorted array:");
        foreach (int i in data) {
            Console.Write(i + " ");
        }
    }
}
