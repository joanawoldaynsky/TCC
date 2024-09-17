using System;

class InsertionSort {
    // Function to sort an array using insertion sort
    public static void InsertionSort(int[] array) {
        int n = array.Length;
        for (int i = 1; i < n; ++i) {
            int key = array[i];
            int j = i - 1;

            // Move elements of array[0..i-1], that are greater than key, to one position ahead of their current position
            while (j >= 0 && array[j] > key) {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    // Driver method to test the above
    public static void Main() {
        int[] array = {12, 11, 13, 5, 6};
        InsertionSort(array);
        Console.WriteLine("Sorted array:");
        foreach (int element in array) {
            Console.Write(element + " ");
        }
    }
}
