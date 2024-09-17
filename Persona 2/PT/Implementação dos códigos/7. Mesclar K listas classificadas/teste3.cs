using System;
using System.Collections.Generic;

public class MergeKSortedLists
{
    public static List<int> MergeKLists(List<List<int>> lists)
    {
        PriorityQueue<Element, int> minHeap = new PriorityQueue<Element, int>();
        
        for (int i = 0; i < lists.Count; i++)
        {
            if (lists[i].Count > 0)
            {
                minHeap.Enqueue(new Element(i, 0, lists[i][0]), lists[i][0]);
            }
        }
        
        List<int> result = new List<int>();
        
        while (minHeap.Count > 0)
        {
            Element current = minHeap.Dequeue();
            result.Add(current.Value);
            
            if (current.Index + 1 < lists[current.ListIndex].Count)
            {
                minHeap.Enqueue(new Element(current.ListIndex, current.Index + 1, lists[current.ListIndex][current.Index + 1]), lists[current.ListIndex][current.Index + 1]);
            }
        }
        
        return result;
    }

    public class Element
    {
        public int ListIndex { get; }
        public int Index { get; }
        public int Value { get; }

        public Element(int listIndex, int index, int value)
        {
            ListIndex = listIndex;
            Index = index;
            Value = value;
        }
    }

    public static void Main()
    {
        List<List<int>> lists = new List<List<int>>
        {
            new List<int> { 1, 4, 5 },
            new List<int> { 1, 3, 4 },
            new List<int> { 2, 6 }
        };

        List<int> mergedList = MergeKLists(lists);
        Console.WriteLine(string.Join(", ", mergedList));
    }
}
