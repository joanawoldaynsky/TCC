using System;

class InsertionSort {
    static void Main() {
        int[] array = { 12, 11, 13, 5, 6 };
        InsertionSortArray(array);
        foreach (int i in array) {
            Console.Write(i + " ");
        }
    }

    static void InsertionSortArray(int[] array) {
        for (int i = 1; i < array.Length; i++) {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key) {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }
}
