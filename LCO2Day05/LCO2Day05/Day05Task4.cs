namespace LCO2Day05;

// Formerly Q3
public class Day05Task4
{
    public static void Run()
    {
        List<int> list1 = [1, 2, 3, 4, 5];
        List<int> list2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Console.WriteLine($"List1 contains same values as list 2? {ContainSameValues(list1, list2)}");
    }

    public static bool ContainSameValues(List<int> set1, List<int> set2)
    {
        if (Subset(set1, set2) && Subset(set2, set1))
        {
            return true;
        }
        return false;   
    }
    
    private static bool Subset(List<int> set1, List<int> set2)
    {
        foreach (int num in set1)
        {
            int index = Day05Task5.LinearSearch(set2, num);
            if (index == 0)
            {
                return false;
            }
        }
        
        return true;   
    }
}