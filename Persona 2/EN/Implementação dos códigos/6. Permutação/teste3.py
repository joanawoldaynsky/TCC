def permute(nums):
    def backtrack(path, used, res):
        if len(path) == len(nums):
            res.append(path[:])
            return
        for i in range(len(nums)):
            if not used[i]:
                used[i] = True
                path.append(nums[i])
                backtrack(path, used, res)
                path.pop()
                used[i] = False

    res = []
    used = [False] * len(nums)
    backtrack([], used, res)
    return res

nums = [1, 2, 3]
permutations = permute(nums)
print(permutations)
