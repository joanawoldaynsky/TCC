import java.util.PriorityQueue;
import java.util.List;
import java.util.ArrayList;

class ListNode {
    int val;
    ListNode next;
    ListNode(int val) { this.val = val; }
}

public class teste2 {

    public static ListNode mergeKLists(List<ListNode> lists) {
        PriorityQueue<ListNode> minHeap = new PriorityQueue<>((a, b) -> a.val - b.val);
        
        for (ListNode node : lists) {
            if (node != null) {
                minHeap.add(node);
            }
        }
        
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (!minHeap.isEmpty()) {
            ListNode minNode = minHeap.poll();
            current.next = minNode;
            current = current.next;
            
            if (minNode.next != null) {
                minHeap.add(minNode.next);
            }
        }
        
        return dummy.next;
    }
    
    public static void main(String[] args) {
        // Example usage
        List<ListNode> lists = new ArrayList<>();
        // Add lists to the 'lists' ArrayList
        
        ListNode mergedList = mergeKLists(lists);
        // Print mergedList
    }
}
