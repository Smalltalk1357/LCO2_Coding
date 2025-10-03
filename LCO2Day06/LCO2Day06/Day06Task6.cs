namespace LCO2Day06;

// Anagram: Given a word and a list of words return the number of words that are anagrams of the others
public class Day06Task6
{
    public static void Run()
    {
        string startWord = "star";
        List<string> wordList = ["rats", "arts", "arc"];
        Console.WriteLine($"Number of anagrams: {AnagramCount(startWord, wordList)}");
    }

    private static int AnagramCount(string startWord, List<string> wordList)
    {
        int result = 0;
        
        foreach (string words in wordList)
        {
            if (IsAnagram(startWord, words))
            {
                result++;
            }
        }
        
        return result;
    }

    private static bool IsAnagram(string word1, string word2)
    {
        List<char> word1Chars = word1.ToCharArray().ToList();
        List<char> word2Chars = word2.ToCharArray().ToList();
        
        word1Chars.Sort();
        word2Chars.Sort();
        
        return word1Chars.SequenceEqual(word2Chars);
    }
}