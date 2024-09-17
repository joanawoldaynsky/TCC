using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class MergeKSortedLists {
    public ListNode MergeKLists(ListNode[] lists) {
        var heap = new SortedSet<(int val, ListNode node)>(Comparer<(int, ListNode)>.Create((a, b) => a.val == b.val ? a.node.GetHashCode().CompareTo(b.node.GetHashCode()) : a.val.CompareTo(b.val)));
        
        foreach (var node in lists) {
            if (node != null) {
                heap.Add((node.val, node));
            }
        }
        
        var dummy = new ListNode(0);
        var current = dummy;
        
        while (heap.Count > 0) {
            var (val, node) = heap.Min;
            heap.Remove(heap.Min);
            current.next = node;
            current = current.next;
            
            if (node.next != null) {
                heap.Add((node.next.val, node.next));
            }
        }
        
        return dummy.next;
    }
    
    public static void Main(string[] args) {
        // Test the implementation here
    }
}
