def permute(arr):
    result = []
    _permute_helper(arr, 0, result)
    return result

def _permute_helper(arr, index, result):
    if index == len(arr) - 1:
        result.append(arr[:])
    else:
        for i in range(index, len(arr)):
            arr[index], arr[i] = arr[i], arr[index]
            _permute_helper(arr, index + 1, result)
            arr[index], arr[i] = arr[i], arr[index]

arr = [1, 2, 3]
result = permute(arr)
print(result)
