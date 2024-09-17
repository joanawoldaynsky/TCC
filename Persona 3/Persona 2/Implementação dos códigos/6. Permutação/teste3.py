def permute(nums):
    result = []
    used = [False] * len(nums)
    backtrack(result, [], nums, used)
    return result

def backtrack(result, temp_list, nums, used):
    if len(temp_list) == len(nums):
        result.append(temp_list[:])
    else:
        for i in range(len(nums)):
            if used[i]:
                continue
            used[i] = True
            temp_list.append(nums[i])
            backtrack(result, temp_list, nums, used)
            used[i] = False
            temp_list.pop()

# Example usage:
nums = [1, 2, 3]
permutations = permute(nums)
print(permutations)
