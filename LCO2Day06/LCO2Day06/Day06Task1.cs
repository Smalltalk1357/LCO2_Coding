namespace LCO2Day06;

// Mexican wave
// The input string will always be lower case but may be empty.
// If the character in the string is whitespace then pass over it as if it was an empty seat
// E.g. Wave("hello") => [ "Hello", "hEllo", "heLlo", "helLo", "hellO"]

public class Day06Task1
{
    public static void Run()
    {
        string input = "ooo ooo";
        Console.WriteLine($"Wave of {input} is {string.Join(", ", Wave(input))}.");
    }

    public static List<string> Wave(string input)
    {
        List<string> result = [];

        if (input.Length != 0)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString().ToUpper();
                if (character != " ")
                {
                    input = input.ToLower();
                    string left = input.Substring(0, i);
                    string right = input.Substring(i + 1);
                    result.Add(left + character + right);
                }
            }
        }
        return result;
    }
}