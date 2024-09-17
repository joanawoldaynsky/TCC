import heapq

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def mergeKLists(self, lists):
        heap = []
        
        for l in lists:
            if l:
                heapq.heappush(heap, (l.val, l))
        
        dummy = ListNode(0)
        current = dummy
        
        while heap:
            val, node = heapq.heappop(heap)
            current.next = node
            current = current.next
            
            if node.next:
                heapq.heappush(heap, (node.next.val, node.next))
        
        return dummy.next

# Test the implementation here
