namespace LCO2Day05;

// Formerly Q2
public class Day05Task3
{
    public static void Run()
    {
        List<int> list1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<int> list2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Console.WriteLine($"");
    }
    
    public static bool AreEqual(List<int> list1, List<int> list2, bool exact = false)
    {
        if (!exact)
        {
            Day05Task5.BubbleSort(ref list1);
            Day05Task5.BubbleSort(ref list2);
        }
        
        if (Day05Task2.ConvertToString(list1) == Day05Task2.ConvertToString(list2))
        {
            return true;
        }
        return false;
    }
}