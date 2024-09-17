using System;
using System.Collections.Generic;

public class MergeKSortedLists
{
    public static List<int> MergeKLists(List<List<int>> lists)
    {
        PriorityQueue<Element, int> minHeap = new PriorityQueue<Element, int>();
        List<int> result = new List<int>();

        // Inicializa o heap com o primeiro elemento de cada lista
        for (int i = 0; i < lists.Count; i++)
        {
            if (lists[i].Count > 0)
            {
                minHeap.Enqueue(new Element(i, 0, lists[i][0]), lists[i][0]);
            }
        }

        while (minHeap.Count > 0)
        {
            Element minElement = minHeap.Dequeue();
            result.Add(minElement.Value);

            int nextIndex = minElement.Index + 1;
            if (nextIndex < lists[minElement.ListIndex].Count)
            {
                minHeap.Enqueue(new Element(minElement.ListIndex, nextIndex, lists[minElement.ListIndex][nextIndex]), lists[minElement.ListIndex][nextIndex]);
            }
        }

        return result;
    }

    public class Element
    {
        public int ListIndex { get; set; }
        public int Index { get; set; }
        public int Value { get; set; }

        public Element(int listIndex, int index, int value)
        {
            ListIndex = listIndex;
            Index = index;
            Value = value;
        }
    }

    public static void Main(string[] args)
    {
        List<List<int>> lists = new List<List<int>>()
        {
            new List<int> {1, 4, 5},
            new List<int> {1, 3, 4},
            new List<int> {2, 6}
        };

        List<int> mergedList = MergeKLists(lists);
        Console.WriteLine(string.Join(", ", mergedList));
    }
}
