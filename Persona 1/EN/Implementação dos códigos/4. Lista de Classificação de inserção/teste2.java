public class teste2 {
    public static void insertionSort(int[] arr) {
        for (int i = 1; i < arr.length; i++) {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    public static void main(String[] args) {
        int[] data = {64, 34, 25, 12, 22, 11, 90};
        System.out.println("Unsorted array:");
        for (int i : data) {
            System.out.print(i + " ");
        }
        insertionSort(data);
        System.out.println("\nSorted array:");
        for (int i : data) {
            System.out.print(i + " ");
        }
    }
}
