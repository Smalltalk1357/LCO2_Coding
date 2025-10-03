namespace LCO2Day06;

//Character codes
// Given an array of integers where each one represents a character code return the string
// Use a StringBuilder in case you get a long int array as input

// Character codes 2
// Remember a byte is nothing but an integer between 0-255 that uses one byte of memory
// To test the byte array: [ 206, 188, 206, 174, 206, 187, 206, 191 ] represents the word for code in Greek

public class Day06Task4
{
    public static void Run()
    {
        List<int> characterCodes = [65, 66, 67, 68, 69, 70, 71, 72];
        Console.WriteLine(StringFromBytes(characterCodes));
    }

    private static string StringFromBytes(List<int> bytes)
    {
        string result = new string(bytes.Select(b => (char)b).ToArray());
        return result;   
    }
}