from heapq import heappush, heappop

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def merge_k_lists(lists):
    heap = []
    
    # Adiciona o primeiro nó de cada lista ao heap
    for l in lists:
        if l:
            heappush(heap, (l.val, l))
    
    dummy = ListNode()
    current = dummy
    
    while heap:
        val, node = heappop(heap)
        current.next = node
        current = current.next
        if node.next:
            heappush(heap, (node.next.val, node.next))
    
    return dummy.next
