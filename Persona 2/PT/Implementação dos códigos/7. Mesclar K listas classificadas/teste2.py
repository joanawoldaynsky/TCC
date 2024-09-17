import heapq

def merge_k_sorted_lists(lists):
    heap = []
    for i, lst in enumerate(lists):
        if lst:
            heapq.heappush(heap, (lst[0], i, 0))

    merged_list = []
    while heap:
        val, list_idx, element_idx = heapq.heappop(heap)
        merged_list.append(val)
        if element_idx + 1 < len(lists[list_idx]):
            next_tuple = (lists[list_idx][element_idx + 1], list_idx, element_idx + 1)
            heapq.heappush(heap, next_tuple)

    return merged_list

# Exemplo de uso
lists = [
    [1, 4, 5],
    [1, 3, 4],
    [2, 6]
]
print(merge_k_sorted_lists(lists))
