namespace LCO2Day06;
// Mexican wave
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