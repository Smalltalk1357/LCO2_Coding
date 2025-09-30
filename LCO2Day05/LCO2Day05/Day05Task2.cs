namespace LCO2Day05;

public class Day05Task2
{
    public static void PrintList<T>(List<T> list, string end = "\n")
    {
        Console.Write($"[{ConvertToString(list)}]{end}");
    }
    
    public static string ConvertToString<T>(List<T> list)
    {
        string listToString = string.Join(", ", list);
        return listToString;
    }
}