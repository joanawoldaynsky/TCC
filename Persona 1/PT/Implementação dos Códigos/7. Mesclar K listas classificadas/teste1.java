import java.util.*;

public class teste1 {
    public static List<Integer> mergeKLists(List<List<Integer>> lists) {
        PriorityQueue<Element> minHeap = new PriorityQueue<>((a, b) -> a.value - b.value);
        List<Integer> result = new ArrayList<>();
        
        // Inicializa o heap com o primeiro elemento de cada lista
        for (int i = 0; i < lists.size(); i++) {
            if (lists.get(i).size() > 0) {
                minHeap.add(new Element(i, 0, lists.get(i).get(0)));
            }
        }

        while (!minHeap.isEmpty()) {
            Element minElement = minHeap.poll();
            result.add(minElement.value);

            int nextIndex = minElement.index + 1;
            if (nextIndex < lists.get(minElement.listIndex).size()) {
                minHeap.add(new Element(minElement.listIndex, nextIndex, lists.get(minElement.listIndex).get(nextIndex)));
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
        List<List<Integer>> lists = Arrays.asList(
            Arrays.asList(1, 4, 5),
            Arrays.asList(1, 3, 4),
            Arrays.asList(2, 6)
        );

        List<Integer> mergedList = mergeKLists(lists);
        System.out.println(mergedList);
    }
}
