namespace LCO2Day05;

public class Day05Task5
{
    public static void Run()
    {
        int num = 10;
        List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10];
        Console.WriteLine($"Number of {num} in list is {LinearSearch(list, num)}");
    }
    
    public static int LinearSearch(List<int> list, int num) // RETURNS NO. HITS
    {
        int result = 0;
        
        foreach (int item in list)
        {
            if (num == item)
            {
                result += 1;
            }
        }
        return result;
    }

    public static int BinarySearch(List<int> list, int num) // RETURNS A SINGLE INDEX
    {
        BubbleSort(ref list);

        if (list.Count == 0)
        {
            return -1;
        }
        
        int top = list[^1]; // Rider suggested using [^1] to get the last element of the list
        int bottom = list[0];
        
        while (true)
        {
            if (top == bottom)
            {
                return -1;
            }
            
            int result = (int)((bottom + top)/2);
            
            if (result == num)
            {
                return list.IndexOf(num);
            }
            if (result > num)
            {
                top = result - 1;
            }
            else if (result < num)
            {
                bottom = result + 1;
            }
        }
    }

    public static int BinarySearchRecursive(List<int> list, int num)
    {
        if (list.Count == 1)
        {
            return -1;
        }
        
        int top = list[^1]; 
        int bottom = list[0];
        
        int result = (int)((bottom + top)/2);
        
        if (result == num)
        {
            return list.IndexOf(num);
        }
        
        if (result > num)
        {
            top = result - 1;
        }
        else if (result < num)
        {
            bottom = result + 1;
        }
    
        return BinarySearchRecursive(list, num);
    }

    public static void BubbleSort(ref List<int> list)
    {
        while (true)
        {
            bool sort = false;
            for (int index = 0; index < list.Count - 1; index++)
            {
                if (list[index] > list[index + 1])
                {
                    (list[index], list[index + 1]) = (list[index + 1], list[index]);
                    sort = true;
                }
            }
            if (!sort)
            {
                return;
            }
        }
    }
}