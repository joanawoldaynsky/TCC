using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

        // Add the head of each list to the priority queue
        foreach (var node in lists) {
            if (node != null) {
                minHeap.Enqueue(node, node.val);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (minHeap.Count > 0) {
            var minNode = minHeap.Dequeue();
            current.next = minNode;
            current = current.next;
            
            if (minNode.next != null) {
                minHeap.Enqueue(minNode.next, minNode.next.val);
            }
        }

        return dummy.next;
    }
}
