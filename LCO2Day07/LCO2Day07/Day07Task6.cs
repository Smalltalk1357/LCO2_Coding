namespace LCO2Day07;

public class Day07Task6
{
    public static void Run()
    {
        
    }
    
    public static Dictionary<string, int> ConvertToDictionary(string filename)
    {
        // returns a sorted dictionary of words in the file and their frequency
        
        List<string> file = Utils.FileToList("stations.txt");
        Dictionary<string, int> wordLists = new Dictionary<string, int>();
        
        foreach (string line in file)
        {
            line.Remove(',');
            List<string> tempList = line.Split(" ").ToList();

            foreach (string word in tempList)
            {
                if (!wordLists.TryAdd(word, 1))
                {
                    wordLists[line]++;
                }
            }
        }
        
        Dictionary<string, int> sorted = wordLists.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        return sorted;
    }
}