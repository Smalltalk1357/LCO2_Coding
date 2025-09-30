namespace LCO2Day05;

// Building on Q2, build a function that takes two lists and returns a Boolean if one list is a subset of the other list
public class Day05Task7
{
    public static void Run()
    {
        List<int> set1 = [1, 2, 3, 4, 5, 11];
        List<int> set2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Console.WriteLine($"Is set1 a subset of set2? {MathematicalSubset(set1, set2)}");
    }

    public static bool MathematicalSubset(List<int> list1, List<int> list2)
    {
        // a mathematical set does not contain duplicates
        List<int> list1Duplicates = Day05Task6.FindDuplicates(list1);
        List<int> list2Duplicates = Day05Task6.FindDuplicates(list2);

        if (list1Duplicates.Count > 0 || list2Duplicates.Count > 0)
        {
            return false;       
        }
        
        if (list1.Count < list2.Count)
        {
            return Day05Task4.ContainSameValues(list1, list2);
        }
        return Day05Task4.ContainSameValues(list2, list1);
    }
}