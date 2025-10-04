namespace LCO2Day06;

// Pig latin: move the first letter to the end of the word and add ay
public class Day06Task8
{
    public static void Run()
    {
        string input = "The quick brown fox , jumps over the lazy dog";
        Console.WriteLine(PigLatin(input));
    }

    private static string PigLatin(string input)
    {
        string[] words = input.Split(' ');
        string result = "";
        
        foreach (string word in words)
        {
            // Needs to check for punctuation - ignore words composed of only punctuation
            bool isPunctuation = false;
            foreach (char character in word)
            {
                if (char.IsPunctuation(character))
                {
                    isPunctuation = true;
                    break;
                }
            }

            if (!isPunctuation)
            {
                string output = "";

                char firstChar = word[0];
                string tempWord = word.Substring(1);

                output = tempWord + firstChar + "ay";
                result += output.ToLower() + ' ';
            }
            else
            {
                result += word + ' ';
            }
        }
        
        result = result.TrimEnd(' ');
        return result;
    }
}
