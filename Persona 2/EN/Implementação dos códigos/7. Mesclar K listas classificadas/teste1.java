import java.util.*;

class ListNode {
    int val;
    ListNode next;
    ListNode(int x) { val = x; }
}

public class teste1 {
    public ListNode mergeKLists(ListNode[] lists) {
        if (lists == null || lists.length == 0) return null;
        PriorityQueue<ListNode> pq = new PriorityQueue<>(lists.length, Comparator.comparingInt(a -> a.val));
        for (ListNode node : lists) {
            if (node != null) {
                pq.add(node);
            }
        }
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while (!pq.isEmpty()) {
            current.next = pq.poll();
            current = current.next;
            if (current.next != null) {
                pq.add(current.next);
            }
        }
        return dummy.next;
    }

    public static void main(String[] args) {
        // Example usage
        // Create some sorted linked lists and merge them
    }
}
