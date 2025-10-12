namespace LCO2Day07;

public class Day07Task6
{
    public static void Question6A()
    {
        // What are the top five words used in tube station names?
        Dictionary<string, int> wordLists = ConvertToDictionary("stations.txt");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(wordLists.ElementAt(i).Key);
        }
    }

    public static void Question6B()
    {
        // What words appear only once?
        Dictionary<string, int> wordLists = ConvertToDictionary("stations.txt", false);
        int count = 0;
        foreach (KeyValuePair<string, int> word in wordLists)
        {
            if (word.Value == 1)
            {
                Console.WriteLine(word.Key);
                count++;
            }
        }
        Console.WriteLine($"Number of words with only one occurrence: {count}");
    }
    
    public static Dictionary<string, int> ConvertToDictionary(string filename, bool sortDescending = true)
    {
        // returns a sorted dictionary of words in the file and their frequency
        
        List<string> file = Utils.FileToList("stations.txt");
        Dictionary<string, int> wordLists = new Dictionary<string, int>();
        
        foreach (string line in file)
        {
            List<string> tempList = line.Split(" ").ToList();

            foreach (string word in tempList)
            {
                // formats string to avoid repeats (not my code)
                string tempWord = new string(word.Where(ch => !char.IsPunctuation(ch) || ch == '\'').ToArray());
                
                // This kept on failing - I don't know why ¯\_(ツ)_/¯
                // tempWord = tempWord.TrimStart('<');
                // tempWord = tempWord.TrimEnd(',');
                // tempWord = tempWord.TrimEnd(')');
                
                if (wordLists.ContainsKey(tempWord))
                {
                    wordLists[tempWord]++;
                }
                else
                {
                    wordLists.Add(tempWord, 1);
                }
            }
        }

        // Sorts the dictionary (not my code)
        var ordered = sortDescending
            ? wordLists.OrderByDescending(x => x.Value).ThenBy(x => x.Key, StringComparer.Ordinal)
            : wordLists.OrderBy(x => x.Value).ThenBy(x => x.Key, StringComparer.Ordinal);
        
        return ordered.ToDictionary(x => x.Key, x => x.Value);
    }
}