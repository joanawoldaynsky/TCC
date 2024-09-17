def permute_generator(arr, k=0):
    if k == len(arr):
        yield arr[:]
    else:
        for i in range(k, len(arr)):
            arr[i], arr[k] = arr[k], arr[i]
            yield from permute_generator(arr, k + 1)
            arr[i], arr[k] = arr[k], arr[i]

if __name__ == "__main__":
    numbers = [1, 2, 3]
    for perm in permute_generator(numbers):
        print(perm)
