namespace LCO2Day05;

// I've continued to call my classes 'DayXTaskY' as it makes it easier for me to work out which questions I've done
public class Day05Task1
{
    public static void Run()
    {
        List<int> list = [0, 1, -5, 10, 23, 30, -15, 8, 4];
        Console.WriteLine($"Sum of list is {SumList(list)}");
        Console.WriteLine($"Largest num in list is {FindMax(list)}");
        Console.WriteLine($"Smallest num in list is {FindMin(list)}");
        string negatives = Day05Task2.ConvertToString(FindNegatives(list));
        Console.WriteLine($"Negatives in the list are {negatives}");
    }

    private static int SumList(List<int> list)
    {
        int total = 0;
        
        foreach (int num in list)
        {
            total += num;
        }
        
        return total;
    }
    
    private static int FindMax(List<int> list)
    {
        int max = list[0];
        
        foreach (int num in list)
        {
            if (num > max)
            {
                max = num;
            }
        }
        
        return max;
    }

    private static int FindMin(List<int> list)
    {
        int min = list[0];
        
        foreach (int num in list)
        {
            if (num < min)
            {
                min = num;
            }
        }
        
        return min;
    }

    private static List<int> FindNegatives(List<int> list)
    {
        List<int> negatives = new List<int>();
        
        foreach (int num in list)
        {
            if (num < 0)
            {
                negatives.Add(num);
            }
        }
        
        return negatives;
    }
}