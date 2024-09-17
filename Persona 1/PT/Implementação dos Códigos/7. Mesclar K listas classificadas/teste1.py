import heapq

def merge_k_lists(lists):
    min_heap = []
    result = []

    # Inicializa o heap com o primeiro elemento de cada lista
    for i in range(len(lists)):
        if lists[i]:
            heapq.heappush(min_heap, (lists[i][0], i, 0))

    while min_heap:
        val, list_idx, elem_idx = heapq.heappop(min_heap)
        result.append(val)

        next_elem_idx = elem_idx + 1
        if next_elem_idx < len(lists[list_idx]):
            heapq.heappush(min_heap, (lists[list_idx][next_elem_idx], list_idx, next_elem_idx))

    return result

# Exemplo de uso
lists = [
    [1, 4, 5],
    [1, 3, 4],
    [2, 6]
]

merged_list = merge_k_lists(lists)
print(merged_list)
