namespace LCO2Day07;

public class Day07Task6
{
    public static void Question6A()
    {
        Dictionary<string, int> wordLists = ConvertToDictionary("stations.txt");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(wordLists.ElementAt(i).Key);
        }
    }

    public static void Question6B()
    {
        Dictionary<string, int> wordLists = ConvertToDictionary("stations.txt", false);
        Console.WriteLine(wordLists.ElementAt(0).Key);
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
                word.TrimEnd(',');
                if (wordLists.ContainsKey(word))
                {
                    wordLists[word]++;
                }
                else
                {
                    wordLists.Add(word, 1);
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