from heapq import heappush, heappop

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def mergeKLists(lists):
    min_heap = []

    # Add the head of each list to the priority queue
    for node in lists:
        if node:
            heappush(min_heap, (node.val, node))

    dummy = ListNode(0)
    current = dummy

    while min_heap:
        min_val, min_node = heappop(min_heap)
        current.next = min_node
        current = current.next

        if min_node.next:
            heappush(min_heap, (min_node.next.val, min_node.next))

    return dummy.next
