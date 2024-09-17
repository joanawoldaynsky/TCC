from heapq import heappop, heappush

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def mergeKLists(lists):
    heap = []
    for l in lists:
        if l:
            heappush(heap, (l.val, l))

    dummy = ListNode()
    current = dummy

    while heap:
        val, node = heappop(heap)
        current.next = ListNode(val)
        current = current.next
        if node.next:
            heappush(heap, (node.next.val, node.next))

    return dummy.next

# Exemplo de uso
l1 = ListNode(1, ListNode(4, ListNode(5)))
l2 = ListNode(1, ListNode(3, ListNode(4)))
l3 = ListNode(2, ListNode(6))

lists = [l1, l2, l3]
result = mergeKLists(lists)
while result:
    print(result.val, end=' ')
    result = result.next
