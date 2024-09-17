def permute(nums):
    result = []
    backtrack(result, [], nums)
    return result

def backtrack(result, temp_list, nums):
    if len(temp_list) == len(nums):
        result.append(temp_list[:])
    else:
        for num in nums:
            if num in temp_list:
                continue
            temp_list.append(num)
            backtrack(result, temp_list, nums)
            temp_list.pop()

# Example usage:
nums = [1, 2, 3]
permutations = permute(nums)
print(permutations)
