def permute(arr, k, result):
    if k == len(arr):
        result.append(arr[:])
    else:
        for i in range(k, len(arr)):
            arr[i], arr[k] = arr[k], arr[i]
            permute(arr, k + 1, result)
            arr[i], arr[k] = arr[k], arr[i]

if __name__ == "__main__":
    numbers = [1, 2, 3]
    result = []
    permute(numbers, 0, result)
    
    for perm in result:
        print(perm)
