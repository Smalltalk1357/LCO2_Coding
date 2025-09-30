namespace LCO2Day03;
// takes a string and counts the number of spaces in the string

public class Day03Task4
{
    public static void Run()
    {
        string teststring = "Hello World 1 2";
        Console.WriteLine($"\"{teststring}\" has {CountSpaces(teststring)} whitespaces");
    }

    public static int CountSpaces(string input)
    {
        int total = 0;

        for (int i = 0; i < input.Length; i++)
            if (input[i] == ' ')
                total++;

        return total;
    }
}