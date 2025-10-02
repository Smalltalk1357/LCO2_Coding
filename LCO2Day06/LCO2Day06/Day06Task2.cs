using System.Text;

namespace LCO2Day06;

// Task 2:
// Convert the word hello to its character codes (one integer for each code) and output them.
// Do this for hello in Chinese as well - In your output message you may wish to use nihao as 你好 may not print to the console
// Test this procedure by calling it from main

// Task 3:
// Convert the word hello to its character codes expressed as a byte array
// You can use Encoding.Default.GetBytes() for this, then output the result
// Remember a byte is nothing but an integer between 0-255 that uses one byte of memory
// Do this for hello in Chinese as well

public class Day06Task2
{
    public static void Run()
    {
        string helloEn = "Hello";
        string helloCn = "你好";
        
        Console.WriteLine($"Character codes of {helloEn} are {String.Join(", ", ByteCodes())}.");
        Console.WriteLine($"Character codes of {helloCn} are {String.Join(", ", ByteCodes(helloCn))}.");
    }

    private static string CharacterCodes(string input = "hello")
    {
        string result = "";
        foreach (char character in input)
        {
            result += (int)character; // returns the character code of the character
            result += " ";
        }
        result = result.TrimEnd();
        
        return result;
    }

    private static List<byte> ByteCodes(string input = "hello")
    {
        List<byte> result = [];
        foreach (byte b in Encoding.Default.GetBytes(input))
        {
            result.Add(b);
        }
        return result;
    }
}