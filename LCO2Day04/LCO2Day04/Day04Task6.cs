namespace LCO2Day04;

public class Day04Task6
{
    public static void Run()
    {
        List<int> numbers = [0, 1, 1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 8, 9, 9];
        Ask(numbers);
    }

    private static void Ask(List<int> n)
    {
        int total = n.Sum();
        int average = total / n.Count;
        int median = n[n.Count / 2];
        if (n.Count % 2 == 0)
        {
            median = (n[n.Count / 2] + n[n.Count / 2 - 1]) / 2;
        }

        List<int> mode = [];
        int maxCount = 0;
        foreach (int number in n)
        {
            if (mode.Contains(n[number]))
                continue;

            int count = -1;

            foreach (int item in n)
            {
                if (item == n[number])
                {
                    count++;
                }
            }

            if (count == maxCount)
            {
                mode.Add(n[number]);
            }

            if (count > maxCount)
            {
                mode.Clear();
                maxCount = count;
            }
        }

        string modeString = string.Join(", ", mode);
        
        Console.WriteLine($"Total of list is {total} and average is {average}");
        Console.WriteLine($"Median is {median} and mode is [{modeString}]");
    }
}