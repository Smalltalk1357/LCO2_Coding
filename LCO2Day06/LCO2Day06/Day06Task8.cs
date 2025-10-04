namespace LCO2Day06;

// Pig latin: move the first letter to the end of the word and add ay
public class Day06Task8
{
    public static void Run()
    {
        string input = "The cat sat on the mat.";
        Console.WriteLine(PigLatin(input));
    }

    public static string PigLatin(string input)
    {
        string[] words = input.Split(' ');
        string result = "";
        
        foreach (string word in words)
        {
            string output = "";
            
            char firstChar = word[0];
            string tempWord = word.Substring(1);
            
            output = tempWord + firstChar + "ay";
            result += output + ' ';
        }
        
        result = result.TrimEnd(' ');
        return result;
    }
}
