def permutar(nums):
    resultados = []
    backtrack(nums, [], resultados)
    return resultados

def backtrack(nums, tempList, resultados):
    if len(tempList) == len(nums):
        resultados.append(tempList[:])
    else:
        for num in nums:
            if num in tempList:
                continue
            tempList.append(num)
            backtrack(nums, tempList, resultados)
            tempList.pop()

nums = [1, 2, 3]
resultados = permutar(nums)
for lista in resultados:
    print(lista)


#############################################################################################
def permutar(nums, file_path):
    with open(file_path, 'w') as f:
        backtrack(nums, [], f)

def backtrack(nums, tempList, file):
    if len(tempList) == len(nums):
        file.write(','.join(map(str, tempList)) + '\n')
    else:
        for num in nums:
            if num in tempList:
                continue
            tempList.append(num)
            backtrack(nums, tempList, file)
            tempList.pop()

nums = [1, 2, 3]
permutar(nums, 'permutacoes.txt')
