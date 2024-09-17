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

public class MergeKSortedLists {
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> heap = new PriorityQueue<ListNode, int>();
        
        // Adiciona o primeiro nó de cada lista ao heap
        foreach (var node in lists) {
            if (node != null) {
                heap.Enqueue(node, node.val);
            }
        }
        
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (heap.Count > 0) {
            var minNode = heap.Dequeue();
            current.next = minNode;
            current = current.next;
            if (minNode.next != null) {
                heap.Enqueue(minNode.next, minNode.next.val);
            }
        }
        
        return dummy.next;
    }
}
