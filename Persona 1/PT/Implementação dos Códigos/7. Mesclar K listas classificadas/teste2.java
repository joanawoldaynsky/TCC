import java.util.*;

class ListNode {
    int val;
    ListNode next;
    ListNode(int x) { val = x; }
}

public class teste2 {
    public ListNode mergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode> heap = new PriorityQueue<>(Comparator.comparingInt(a -> a.val));
        
        for (ListNode node : lists) {
            if (node != null) {
                heap.add(node);
            }
        }
        
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (!heap.isEmpty()) {
            ListNode node = heap.poll();
            current.next = node;
            current = current.next;
            
            if (node.next != null) {
                heap.add(node.next);
            }
        }
        
        return dummy.next;
    }
    
    public static void main(String[] args) {
        // Test the implementation here
    }
}
