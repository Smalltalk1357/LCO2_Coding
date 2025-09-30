namespace LCO2Day05;

// Reverse a list in-place
public class Day05Task8
{
    public static void Run()
    {
        List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        ReverseList(ref list);
        Day05Task2.PrintList(list);
    }
    
    public static void ReverseList<T>(ref List<T> list)
    {
        int iterated = list.Count / 2;
        for (int index = 0; index < iterated; index++)
        {
            (list[index], list[list.Count - index - 1]) = (list[list.Count - index - 1], list[index]);
        }
    }
}