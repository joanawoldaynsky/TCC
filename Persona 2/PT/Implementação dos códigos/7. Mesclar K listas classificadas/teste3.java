import java.util.*;

public class teste3 {
    public static List<Integer> mergeKLists(List<List<Integer>> lists) {
        PriorityQueue<Element> minHeap = new PriorityQueue<>(new Comparator<Element>() {
            @Override
            public int compare(Element e1, Element e2) {
                return Integer.compare(e1.value, e2.value);
            }
        });
        
        for (int i = 0; i < lists.size(); i++) {
            if (lists.get(i).size() > 0) {
                minHeap.add(new Element(i, 0, lists.get(i).get(0)));
            }
        }
        
        List<Integer> result = new ArrayList<>();
        
        while (!minHeap.isEmpty()) {
            Element current = minHeap.poll();
            result.add(current.value);
            
            if (current.index + 1 < lists.get(current.listIndex).size()) {
                minHeap.add(new Element(current.listIndex, current.index + 1, lists.get(current.listIndex).get(current.index + 1)));
            }
        }
        
        return result;
    }

    static class Element {
        int listIndex;
        int index;
        int value;

        Element(int listIndex, int index, int value) {
            this.listIndex = listIndex;
            this.index = index;
            this.value = value;
        }
    }

    public static void main(String[] args) {
        List<List<Integer>> lists = new ArrayList<>();
        lists.add(Arrays.asList(1, 4, 5));
        lists.add(Arrays.asList(1, 3, 4));
        lists.add(Arrays.asList(2, 6));

        List<Integer> mergedList = mergeKLists(lists);
        System.out.println(mergedList);
    }
}
