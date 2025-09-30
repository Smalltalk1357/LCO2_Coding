namespace LCO2Day05;

public class Day05Task9
{
    public static void Run()
    {
        List<int> list = [];
        while (list.Count < 20)
        {
            list.Add(Random.Shared.Next(1, 100));
        }
        QuickSort(ref list);
        Day05Task2.PrintList(list);
    }
    
    // Just uses Day05Task5.BubbleSort()
    public static void BubbleSort(ref List<int> list)
    {
        Day05Task5.BubbleSort(ref list);
    }
    
    // Based off this: https://idea-instructions.com/quick-sort/
    // Quicksort algorithm not finished
    public static void QuickSort(ref List<int> list)
    {
        if (list.Count <= 1)
        {
            return;
        }
        
        int pivot = Random.Shared.Next(0, list.Count);
        int pivotValue = list[pivot];

        for(int i = 0; i < list.Count; i++)
        {
            int num = list[i];
            if (num > pivotValue)
            {
                list.RemoveAt(i);
                list.Add(num);
            }
            else
            {
                list.RemoveAt(i);
                list.Insert(0, num);
            }
        }

        List<int> leftHalf = list.GetRange(pivot, list.Count - pivot);
        List<int> rightHalf = list.GetRange(0, pivot);

        QuickSort(ref leftHalf);
        QuickSort(ref rightHalf);

        list.Clear();
        list.AddRange(leftHalf);
        list.AddRange(rightHalf);
    }
}