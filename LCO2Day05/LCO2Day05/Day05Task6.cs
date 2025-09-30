namespace LCO2Day05;

public class Day05Task6
{
    public static void Run()
    {
        List<int> list = [1, 2, 10, 4, 5, 8, 7, 8, 9, 10];
        list = FindDuplicates(list);
        Day05Task2.PrintList(list);
    }
    
    public static List<int> FindDuplicates(List<int> list)
    {
        Day05Task5.BubbleSort(ref list);
        
        List<int> duplicates = [];
        
        // Linear search returns NO HITS!!!
        foreach (int num in list)
        {
            if (Day05Task5.LinearSearch(list, num) > 1 && Day05Task5.LinearSearch(duplicates, num) == 0)
            {
                duplicates.Add(num);
            }
        }
        
        return duplicates;
    }
}