def insertion_sort(array):
    for i in range(1, len(array)):
        key = array[i]
        j = i - 1
        
        # Move elements of array[0..i-1], that are greater than key,
        # to one position ahead of their current position
        while j >= 0 and key < array[j]:
            array[j + 1] = array[j]
            j -= 1
        array[j + 1] = key

if __name__ == "__main__":
    array = [12, 11, 13, 5, 6]
    insertion_sort(array)
    print("Sorted array:", array)
