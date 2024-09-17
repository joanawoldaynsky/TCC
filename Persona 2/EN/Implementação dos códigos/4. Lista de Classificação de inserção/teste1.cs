using System;

class InsertionSort {
    static void InsertionSortAlgorithm(int[] array) {
        for (int i = 1; i < array.Length; i++) {
            int key = array[i];
            int j = i - 1;
            
            // Move elements of array[0..i-1], that are greater than key,
            // to one position ahead of their current position
            while (j >= 0 && array[j] > key) {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    static void Main() {
        int[] array = {12, 11, 13, 5, 6};
        InsertionSortAlgorithm(array);
        Console.WriteLine("Sorted array:");
        foreach (int item in array) {
            Console.Write(item + " ");
        }
    }
}
