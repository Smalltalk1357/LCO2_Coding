namespace LCO2Day06;

// Convert the word hello to its character codes (one integer for each code) and output them.
// Do this for hello in Chinese as well - In your output message you may wish to use nihao as 你好 may not print to the console
// Test this procedure by calling it from main

public class Day06Task2
{
    public static void Run()
    {
        string helloCn = "你好";
        string helloEn = "Hello";
        
        Console.WriteLine($"Character codes of {helloCn} are {CharacterCodes(helloCn)}.");
        Console.WriteLine($"Character codes of {helloEn} are {CharacterCodes(helloEn)}.");
    }

    private static string CharacterCodes(string input = "hello")
    {
        string result = "";
        foreach (char character in input)
        {
            result += (int)character; // returns the code of the character
            result += " ";
        }
        return result;
    }
}