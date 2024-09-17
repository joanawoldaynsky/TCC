using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class MergeKSortedLists {
    public ListNode MergeKLists(List<ListNode> lists) {
        var minHeap = new SortedSet<(int val, ListNode node)>(Comparer<(int, ListNode)>.Create((a, b) => {
            int result = a.val.CompareTo(b.val);
            return result != 0 ? result : a.node.GetHashCode().CompareTo(b.node.GetHashCode());
        }));

        foreach (var node in lists) {
            if (node != null) {
                minHeap.Add((node.val, node));
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (minHeap.Count > 0) {
            var minNode = minHeap.Min;
            minHeap.Remove(minNode);
            current.next = minNode.node;
            current = current.next;

            if (minNode.node.next != null) {
                minHeap.Add((minNode.node.next.val, minNode.node.next));
            }
        }

        return dummy.next;
    }
    
    public static void Main(string[] args) {
        // Example usage
        List<ListNode> lists = new List<ListNode>();
        // Add lists to the 'lists' List

        MergeKSortedLists merger = new MergeKSortedLists();
        ListNode mergedList = merger.MergeKLists(lists);
        // Print mergedList
    }
}
